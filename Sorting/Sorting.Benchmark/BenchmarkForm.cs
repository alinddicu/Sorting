namespace Sort.Benchmark
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Windows.Forms;

	using Sorting;
	using System.Reflection;
	using Sorting.Algorithms;

	public partial class BenchmarkForm : Form, IBenchmarkForm
	{
		private int _maxValuesToSort = 200;
		private int _drawDelay = 150;
		private FlowLayoutPanel _basePanel;
		private readonly List<IBenchBackgroundWorker> _benchBackgroundWorkers = new List<IBenchBackgroundWorker>();
		private readonly UniqueElementsGenerator _generator = new UniqueElementsGenerator();
		private readonly RankingSystem _rankingSystem = new RankingSystem(6);

		private IEnumerable<int> _unsortedList;

		public BenchmarkForm()
		{
			InitializeComponent();
			Shuffle();
			InitBasePanel();
			InitBenchWorkers();
			InitForm();

			_basePanel.Height = Height + menuStripBench.Height;

			EnableButtons(true, false, true);
		}

		private void InitBasePanel()
		{
			_basePanel = new FlowLayoutPanel
			{
				Width = Width,
				Padding = new Padding(0, menuStripBench.Height, 0, 0), // bug fix: menu strip was covering the top of the rop panels
				Dock = DockStyle.Fill
			};
			Controls.Add(_basePanel);
		}

		private void Shuffle()
		{
			Cursor.Current = Cursors.WaitCursor;
			_rankingSystem.Clear();
			_unsortedList = _generator.Execute(_maxValuesToSort).ToArray();
			Cursor.Current = Cursors.Default;
		}

		private void InitForm()
		{
			var count = _benchBackgroundWorkers.Count;
			var benchPanel = _benchBackgroundWorkers.First().BenchPanel;

			var weightCount = count < 3 ? count : 3;
			Width = weightCount * (benchPanel.Width + 12);
			var heightCount = count <= 3 ? 1 : (count % 3 == 0 ? count / 3: count / 3 + 1);
			Height = heightCount * (benchPanel.Height + 3) + menuStripBench.Height + 50;
			SetText();
			CenterToScreen();
		}

		private void SetText()
		{
			Text = $"Sorting algorithms benchmark on {_maxValuesToSort} values";
		}

		private void InitBenchWorkers()
		{
			var benchPanels = Assembly.GetAssembly(typeof(SortBase))
				.GetHeirsOf<SortBase>(_rankingSystem)
				.Select(sort => new BenchPanel(sort, _unsortedList, _maxValuesToSort));
			//var fourSorts = new SortBase[]
			//{
			//	new InsertionSort(_rankingSystem),
			//	new BubbleSort(_rankingSystem),
			//	new MergeSort(_rankingSystem),
			//	new QuickSort(_rankingSystem),
			//	new InsertionSort(_rankingSystem),
			//	new BubbleSort(_rankingSystem),
			//	new MergeSort(_rankingSystem),
			//	new QuickSort(_rankingSystem),
			//	new BubbleSort(_rankingSystem),
			//	new MergeSort(_rankingSystem),
			//	new QuickSort(_rankingSystem)
			//};
			//var benchPanels = fourSorts.Select(s => new BenchPanel(s, _unsortedList, _maxValuesToSort));
			foreach (var benchPanel in benchPanels)
			{
				_basePanel.Controls.Add(benchPanel);
				var benchBwWorker = new BenchBackgroundWorker(benchPanel, _drawDelay);
				_benchBackgroundWorkers.Add(benchBwWorker);
			}

			SetSortRanks();
		}

		private void startToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			_rankingSystem.Clear();
			foreach (var benchBwWorker in _benchBackgroundWorkers)
			{
				benchBwWorker.SetDrawDelay(_drawDelay);
				benchBwWorker.BenchPanel.Init(_unsortedList);
				benchBwWorker.RunWorkerAsync();
			}

			SetSortRanks();
			EnableButtons(false, true, false);
		}

		private void stopToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			foreach (var benchBackgroundWorker in _benchBackgroundWorkers)
			{
				benchBackgroundWorker.CancelAsync();
			}

			EnableButtons(true, false, true);
		}

		private void EnableButtons(bool startEnabled, bool stopEnabled, bool shuffleEnabled)
		{
			startToolStripMenuItem.Enabled = startEnabled;
			stopToolStripMenuItem.Enabled = stopEnabled;
			shuffleToolStripMenuItem.Enabled = shuffleEnabled;
		}

		private void shuffleToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			ShuffleAction();
		}

		private void ShuffleAction()
		{
			Shuffle();
			foreach (var benchBwWorker in _benchBackgroundWorkers)
			{
				benchBwWorker.BenchPanel.Init(_unsortedList);
				benchBwWorker.BenchPanel.DrawIntermediateSort(0);
			}

			SetSortRanks();
		}

		private void SetSortRanks()
		{
			foreach (var benchBwWorker in _benchBackgroundWorkers)
			{
				benchBwWorker.BenchPanel.SetSortRanks();
			}
		}

		private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void optionsToolStripMenuItem2_Click(object sender, System.EventArgs e)
		{
			var optionsForm = new OptionsForm(this, _maxValuesToSort, _drawDelay);
			optionsForm.ShowDialog();
		}

		public void UpdateOptions(int maxValuesToSort, int drawDelay)
		{
			if (_maxValuesToSort != maxValuesToSort)
			{
				_maxValuesToSort = maxValuesToSort;
				SetText();
				ShuffleAction();
			}

			_drawDelay = drawDelay;
		}
	}
}

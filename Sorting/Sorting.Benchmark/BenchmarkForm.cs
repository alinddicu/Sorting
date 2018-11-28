namespace Sort.Benchmark
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Windows.Forms;

	using Sorting;
	using System.Reflection;
	using Sorting.Algorithms;

	public partial class BenchmarkForm : Form
	{
		private readonly int _maxSortValue;
		private FlowLayoutPanel _basePanel;
		private readonly List<BenchBackgroundWorker> _benchBackgroundWorkers = new List<BenchBackgroundWorker>();
		private readonly UniqueElementsGenerator _generator = new UniqueElementsGenerator();
		private readonly RankingSystem _rankingSystem = new RankingSystem();

		private IEnumerable<int> _unsortedList;

		public BenchmarkForm(int maxSortValue)
		{
			_maxSortValue = maxSortValue;
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
			_rankingSystem.Clear();
			_unsortedList = _generator.Execute(_maxSortValue).ToArray();
		}

		private void InitForm()
		{
			var count = _benchBackgroundWorkers.Count;
			var benchPanel = _benchBackgroundWorkers.First().BenchPanel;

			var weightCount = count < 3 ? count : 3;
			Width = weightCount * (benchPanel.Width + 12);
			var heightCount = count <= 3 ? 1 : count / 3 + 1;
			Height = heightCount * (benchPanel.Height + 3) + menuStripBench.Height + 50;
			Text = $"Sorting algorithms benchmark on {_maxSortValue} values";
			CenterToScreen();
		}

		private void InitBenchWorkers()
		{
			var benchPanels = Assembly.GetAssembly(typeof(SortBase))
				.GetHeirsOf<SortBase>(_rankingSystem)
				.Select(sort => new BenchPanel(sort, _unsortedList, _maxSortValue));
			//var fourSorts = new SortBase[]
			//{
			//	new InsertionSort(_rankingSystem), new BubbleSort(_rankingSystem), new MergeSort(_rankingSystem), //new QuickSort(_rankingSystem),
			//	new InsertionSort(_rankingSystem), new BubbleSort(_rankingSystem), new MergeSort(_rankingSystem), new QuickSort(_rankingSystem)
			//};
			//var benchPanels = fourSorts.Select(s => new BenchPanel(s, _unsortedList, _maxSortValue));
			foreach (var benchPanel in benchPanels)
			{
				_basePanel.Controls.Add(benchPanel);
				var benchBwWorker = new BenchBackgroundWorker(benchPanel);
				_benchBackgroundWorkers.Add(benchBwWorker);
			}

			SetSortRanks();
		}

		private void startToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			_rankingSystem.Clear();
			foreach (var benchBwWorker in _benchBackgroundWorkers)
			{
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
	}
}

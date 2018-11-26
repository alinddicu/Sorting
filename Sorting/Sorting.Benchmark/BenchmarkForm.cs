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

			Width = 3 * (benchPanel.Width + 12);
			Height = count / 2 * benchPanel.Height + menuStripBench.Height + 51;
			Text = $"Sorting algorithms benchmark on {_maxSortValue} values";
			CenterToScreen();
		}

		private void InitBenchWorkers()
		{
			var benchPanels = Assembly.GetAssembly(typeof(SortBase))
				.GetHeirsOf<SortBase>(_rankingSystem)
				.Select(sort => new BenchPanel(sort, _unsortedList, _maxSortValue));
			//var fourSorts = new SortBase[] { new InsertionSort(), new BubbleSort(), new MergeSort(), new QuickSort(),  };
			//var benchPanels = fourSorts.Select(s => new BenchPanel(s, _unsortedList, _maxSortValue));
			foreach (var benchPanel in benchPanels)
			{
				_basePanel.Controls.Add(benchPanel);
				var benchBwWorker = new BenchBackgroundWorker(benchPanel);
				_benchBackgroundWorkers.Add(benchBwWorker);
			}

			SetRanks();
		}

		private void startToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			_rankingSystem.Clear();
			foreach (var benchBwWorker in _benchBackgroundWorkers)
			{
				benchBwWorker.BenchPanel.Init(_unsortedList);
				benchBwWorker.RunWorkerAsync();
			}
			
			SetRanks();
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

			SetRanks();
		}

		private void SetRanks()
		{
			foreach (var benchBwWorker in _benchBackgroundWorkers)
			{
				benchBwWorker.BenchPanel.SetRanks();
			}
		}
	}
}

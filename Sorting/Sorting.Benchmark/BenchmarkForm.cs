namespace Sort.Benchmark
{
	using System.Linq;
	using System.Windows.Forms;

	using Sorting;
	using System.Reflection;
	using System.Collections.Generic;

	public partial class BenchmarkForm : Form
	{
		private readonly List<string> _sortRanking = new List<string>();
		private readonly int _maxSortValue;

		public BenchmarkForm(int maxSortValue)
		{
			_maxSortValue = maxSortValue;
			InitializeComponent();
			InitForm();
			InitBenchWorkers();
		}

		private void InitForm()
		{
			Width = 445;
			Height = 480;
			CenterToScreen();
		}

		private void InitBenchWorkers()
		{
			var basePanel = new FlowLayoutPanel { Width = Width, Height = Height, Dock = DockStyle.Fill };

			var unsortedList = new UniqueElementsGenerator().Execute(_maxSortValue);
			var benchPanels = Assembly.GetAssembly(typeof(SortBase))
				.GetHeirsOf<SortBase>()
				.Select(sort => new BenchPanel(sort, unsortedList, _maxSortValue));
			foreach (var benchPanel in benchPanels)
			{
				basePanel.Controls.Add(benchPanel);
				var bubbleBwWorker = new BenchBackgroundWorker(benchPanel, _sortRanking);
				bubbleBwWorker.RunWorkerAsync();
			}

			Controls.Add(basePanel);
		}
	}
}

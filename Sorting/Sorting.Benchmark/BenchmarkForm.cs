﻿namespace Sort.Benchmark
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
		private readonly FlowLayoutPanel _basePanel;
		private readonly List<BenchBackgroundWorker> _benchBackgroundWorkers = new List<BenchBackgroundWorker>();
		private readonly UniqueElementsGenerator _generator = new UniqueElementsGenerator();

		private readonly IEnumerable<int> _unsortedList;

		public BenchmarkForm(int maxSortValue)
		{
			_maxSortValue = maxSortValue;
			InitializeComponent();
			InitForm();
			_basePanel = new FlowLayoutPanel
			{
				Width = Width,
				Padding = new Padding(0, menuStripBench.Height, 0, 0), // bug fix: menu strip was covering the top of the rop panels
				Height = Height + menuStripBench.Height,
				Dock = DockStyle.Fill
			};
			Controls.Add(_basePanel);

			_unsortedList = _generator.Execute(_maxSortValue).ToArray();
			InitBenchWorkers();
			EnableButtons(true, false);
		}

		private void InitForm()
		{
			Width = 429;
			Height = 475 + menuStripBench.Height;
			CenterToScreen();
		}

		private void InitBenchWorkers()
		{
			var benchPanels = Assembly.GetAssembly(typeof(SortBase))
				.GetHeirsOf<SortBase>()
				.Select(sort => new BenchPanel(sort, _unsortedList, _maxSortValue));
			//var benchPanels = new [] {new BenchPanel(new InsertionSort(), _unsortedList, _maxSortValue) };
			foreach (var benchPanel in benchPanels)
			{
				_basePanel.Controls.Add(benchPanel);
				var benchBwWorker = new BenchBackgroundWorker(benchPanel);
				_benchBackgroundWorkers.Add(benchBwWorker);
			}
		}

		private void startToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			foreach (var benchBwWorker in _benchBackgroundWorkers)
			{
				benchBwWorker.BenchPanel.Init(_unsortedList);
				benchBwWorker.RunWorkerAsync();
			}

			EnableButtons(false, true);
		}

		private void cancelToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			foreach (var benchBackgroundWorker in _benchBackgroundWorkers)
			{
				benchBackgroundWorker.CancelAsync();
			}

			EnableButtons(true, false);
		}

		private void EnableButtons(bool startEnabled, bool cancelEnabled)
		{
			startToolStripMenuItem.Enabled = startEnabled;
			cancelToolStripMenuItem.Enabled = cancelEnabled;
		}
	}
}

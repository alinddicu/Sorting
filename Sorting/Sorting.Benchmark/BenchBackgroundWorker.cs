namespace Sort.Benchmark
{
	using System.ComponentModel;
	using System.Threading;

	public class BenchBackgroundWorker : BackgroundWorker
	{
		private int _drawDelay;
		private bool _keepRunning = true;

		public BenchBackgroundWorker(BenchPanel benchPanel, int drawDelay)
		{
			_drawDelay = drawDelay;
			WorkerReportsProgress = true;
			WorkerSupportsCancellation = true;
			BenchPanel = benchPanel;
			DoWork += DoWorkHandler;
			ProgressChanged += ProgressChangedHandler;
			RunWorkerCompleted += RunWorkerCompletedHandler;
		}

		private void RunWorkerCompletedHandler(object sender, RunWorkerCompletedEventArgs e)
		{
			_keepRunning = false;
		}

		public BenchPanel BenchPanel { get; }

		private void DoWorkHandler(object sender, DoWorkEventArgs e)
		{
			_keepRunning = true;
			var bbw = sender as BenchBackgroundWorker;
			for (var i = 0; i < BenchPanel.IntermediateSorts.Count && !CancellationPending && _keepRunning; i++)
			{
				Thread.Sleep(_drawDelay);
				bbw.ReportProgress(i);
			}

			_keepRunning = false;
		}

		private void ProgressChangedHandler(object sender, ProgressChangedEventArgs e)
		{
			BenchPanel.DrawIntermediateSort(e.ProgressPercentage);
		}

		public void SetDrawDelay(int drawDelay)
		{
			_drawDelay = drawDelay;
		}
	}
}

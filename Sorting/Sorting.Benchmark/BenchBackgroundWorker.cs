namespace Sort.Benchmark
{
	using System.ComponentModel;
	using System.Threading;

	public class BenchBackgroundWorker : BackgroundWorker
	{
		private readonly BenchPanel _benchPanel;

		public BenchBackgroundWorker(BenchPanel benchPanel)
		{
			WorkerReportsProgress = true;
			WorkerSupportsCancellation = true;
			_benchPanel = benchPanel;
			DoWork += DoWorkHandler;
			ProgressChanged += ProgressChangedHandler;
		}

		private void DoWorkHandler(object sender, DoWorkEventArgs e)
		{
			var bbw = sender as BenchBackgroundWorker;
			for (var i = 0; i < _benchPanel.IntermediateSorts.Count && !CancellationPending; i++)
			{
				Thread.Sleep(100);
				bbw.ReportProgress(i);
			}
		}

		private void ProgressChangedHandler(object sender, ProgressChangedEventArgs e)
		{
			_benchPanel.DrawIntermediateSort(e.ProgressPercentage);
		}
	}
}

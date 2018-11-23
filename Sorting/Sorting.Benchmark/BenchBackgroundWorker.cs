namespace Sort.Benchmark
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Threading;

	public class BenchBackgroundWorker : BackgroundWorker
    {
        private readonly BenchPanel _benchPanel;

        public BenchBackgroundWorker(BenchPanel benchPanel)
        {
            WorkerReportsProgress = true;
            _benchPanel = benchPanel;
            DoWork += DoWorkHandler;
            ProgressChanged += ProgressChangedHandler;
        }

        private void DoWorkHandler(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            for (var i = 0; i < _benchPanel.IntermediateSorts.Count; i++)
            {
                Thread.Sleep(50);
                worker.ReportProgress(i);
            }
        }

        private void ProgressChangedHandler(object sender, ProgressChangedEventArgs e)
        {
            _benchPanel.DrawIntermediateSort(e.ProgressPercentage);
        }
    }
}

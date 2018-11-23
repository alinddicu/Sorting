namespace Sort.Benchmark
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Threading;

	public class BenchBackgroundWorker : BackgroundWorker
    {
        private readonly List<string> _sortRanking;
        private readonly BenchPanel _benchPanel;

        public BenchBackgroundWorker(BenchPanel benchPanel, List<string> sortRanking)
        {
            WorkerReportsProgress = true;
            _benchPanel = benchPanel;
            _sortRanking = sortRanking;
            DoWork += DoWorkHandler;
            ProgressChanged += ProgressChangedHandler;
            RunWorkerCompleted += RunWorkerCompletedHandler;
        }

        private void RunWorkerCompletedHandler(object sender, RunWorkerCompletedEventArgs e)
        {
            string rankLabelText;
            if (e.Cancelled)
            {
				rankLabelText = "Canceled!";
            }
            else if (e.Error != null)
            {
				rankLabelText = "Error: " + e.Error.Message;
            }
            else
            {
                _sortRanking.Add(_benchPanel.SortName);
				rankLabelText = $"Rank {GetRank()}";
            }

            _benchPanel.UpdateRank(rankLabelText);
        }

        private int GetRank()
        {
            var count = _sortRanking.Count;
            for (var i = 0; i < count; i++)
            {
                var item = _sortRanking[i];
                if (item == _benchPanel.SortName)
                {
                    return i + 1;
                }
            }

            return count;
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

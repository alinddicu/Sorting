namespace Sort.Benchmark
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;

    public class BenchBackgroundWorker : BackgroundWorker
    {
        private readonly List<string> _sortRanking;
        private readonly BenchPanel _benchPanel;
        private readonly int _maxSortValue;

        public BenchBackgroundWorker(BenchPanel benchPanel, int maxSortValue, List<string> sortRanking)
        {
            WorkerReportsProgress = true;
            _benchPanel = benchPanel;
            _maxSortValue = maxSortValue;
            _sortRanking = sortRanking;
            DoWork += DoWorkHandler;
            ProgressChanged += ProgressChangedHandler;
            RunWorkerCompleted += RunWorkerCompletedHandler;
        }

        private void RunWorkerCompletedHandler(object sender, RunWorkerCompletedEventArgs e)
        {
            var controlLabel = GetControlLabel();
            controlLabel.BringToFront();
            if (e.Cancelled == true)
            {
                controlLabel.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                controlLabel.Text = "Error: " + e.Error.Message;
            }
            else
            {
                _sortRanking.Add(_benchPanel.SortName);
                controlLabel.Text = GetRank().ToString();
            }

            controlLabel.Refresh();
        }

        private Label GetControlLabel()
        {
            return (Label)_benchPanel.Controls.Find("ControlLabel", true)[0];
        }

        private int GetRank()
        {
            var count = _sortRanking.Count;
            for (int i = 0; i < count; i++)
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

            var intermediateSorts = _benchPanel.IntermediateSorts.ToArray();
            for (var i = 0; i < intermediateSorts.Length; i++)
            {
                Thread.Sleep(10);
                var intermediateSort = intermediateSorts[i];
                worker.ReportProgress(i, new BenchPanelProgessChangedStateData(intermediateSort));
            }
        }

        private void ProgressChangedHandler(object sender, ProgressChangedEventArgs e)
        {
            var graphics = _benchPanel.CreateGraphics();
            var benchProgessChanged = (BenchPanelProgessChangedStateData)e.UserState;
            graphics.Clear(_benchPanel.BackColor);
            var numbers = benchProgessChanged.IntermediateSort.ToArray();
            var pen = new Pen(Color.DarkGreen);
            var height = _benchPanel.Height;
            var width = _benchPanel.Width;

            var heightFactor = (double)height / _maxSortValue;
            var widthFactor = (double)width / _maxSortValue;

            for (var i = 0; i < numbers.Length; i++)
            {
                var number = numbers[i];
                graphics.DrawLine(
                    pen,
                    (int)widthFactor * i,
                    (int)height,
                    (int)widthFactor * i,
                    (int)(height - number * heightFactor));
            }
        }
    }
}

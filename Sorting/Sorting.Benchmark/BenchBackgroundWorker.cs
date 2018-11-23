namespace Sort.Benchmark
{
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Threading;

    public class BenchBackgroundWorker : BackgroundWorker
    {
        private readonly BenchPanel _benchPanel;
        private readonly int _maxSortValue;

        public BenchBackgroundWorker(BenchPanel benchPanel, int maxSortValue)
        {
            WorkerReportsProgress = true;
            _benchPanel = benchPanel;
            _maxSortValue = maxSortValue;
            DoWork += DoWorkHandler;
            ProgressChanged += ProgressChangedHandler;
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

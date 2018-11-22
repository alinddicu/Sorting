namespace Sort.Benchmark
{
	using System.ComponentModel;
	using System.Drawing;
	using System.Linq;
	using System.Threading;

	public class BenchBackgroundWorker: BackgroundWorker
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
			for (var i = 0; i < numbers.Length; i++)
			{
				var x = i;
				var number = numbers[i];
				graphics.DrawLine(pen, x, height, x, height - number);
			}
		}
	}
}

namespace Sort.Benchmark
{
	using System.ComponentModel;
	using System.Drawing;
	using System.Linq;
	using System.Threading;
	using System.Windows.Forms;

	using Sorting;
	using Sorting.Algorithms;

	public partial class BenchmarkForm : Form
	{
		private readonly BenchPanel _selectionPanel;

		public BenchmarkForm()
		{
			InitializeComponent();

			var unsortedList = new UniqueElementsGenerator().Execute(100).ToArray();

			_selectionPanel = new BenchPanel(new BubbleSort(), unsortedList)
			{
				BackColor = Color.Black,
				Location = new Point(0, 0)
			};
			Controls.Add(_selectionPanel);
			backgroundWorker1.WorkerReportsProgress = true;
			backgroundWorker1.RunWorkerAsync();

			//var insertionPanel = new BenchPanel(new InsertionSort(), unsortedList)
			//{
			//	BackColor = Color.Black,
			//	Location = new Point(101, 0)
			//};
			//Controls.Add(insertionPanel);

			//var bubblePanel = new BenchPanel(new BubbleSort(), unsortedList)
			//{
			//	BackColor = Color.Black,
			//	Location = new Point(202, 0)
			//};
			//Controls.Add(bubblePanel);
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			var worker = sender as BackgroundWorker;
			
			var intermediateSorts = _selectionPanel.IntermediateSorts.ToArray();
			for (var i = 0; i < intermediateSorts.Length; i++)
			{
				Thread.Sleep(10);
				var intermediateSort = intermediateSorts[i];
				worker.ReportProgress(i, new BenchProgessChanged(intermediateSort));
			}
		}

		private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			var graphics = _selectionPanel.CreateGraphics();
			var benchProgessChanged = (BenchProgessChanged) e.UserState;
			graphics.Clear(_selectionPanel.BackColor);
			var numbers = benchProgessChanged.IntermediateSort.ToArray();
			var pen = new Pen(Color.DarkGreen);
			var height = _selectionPanel.Height;
			for (var i = 0; i < numbers.Length; i++)
			{
				var x = i;
				var number = numbers[i];
				graphics.DrawLine(pen, x, height, x, height - number);
			}

			//_selectionPanel.Refresh();
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{

		}
	}
}

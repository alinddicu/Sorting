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
		public BenchmarkForm()
		{
			InitializeComponent();

			var unsortedList = new UniqueElementsGenerator().Execute(100).ToArray();

			var bubblePanel = new BenchPanel(new BubbleSort(), unsortedList)
			{
				BackColor = Color.Black,
				Location = new Point(0, 0)
			};
			Controls.Add(bubblePanel);
			var bubbleBwWorker = new BenchBackgroundWorker(bubblePanel);
			bubbleBwWorker.RunWorkerAsync();

			var insertionPanel = new BenchPanel(new InsertionSort(), unsortedList)
			{
				BackColor = Color.Black,
				Location = new Point(101, 0)
			};
			Controls.Add(insertionPanel);
			var insertionBwWorker = new BenchBackgroundWorker(insertionPanel);
			insertionBwWorker.RunWorkerAsync();

			var selectionPanel = new BenchPanel(new InsertionSort(), unsortedList)
			{
				BackColor = Color.Black,
				Location = new Point(202, 0)
			};
			Controls.Add(selectionPanel);
			var selectionBwWorker = new BenchBackgroundWorker(selectionPanel);
			selectionBwWorker.RunWorkerAsync();
		}
	}
}

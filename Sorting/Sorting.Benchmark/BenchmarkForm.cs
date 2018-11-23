namespace Sort.Benchmark
{
	using System.Drawing;
	using System.Linq;
	using System.Windows.Forms;

	using Sorting;
	using Sorting.Algorithms;

	public partial class BenchmarkForm : Form
	{
		public BenchmarkForm()
		{
			InitializeComponent();
            var basePanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill
            };
            Controls.Add(basePanel);

            var unsortedList = new UniqueElementsGenerator().Execute(100).ToArray();

			var bubblePanel = new BenchPanel(new BubbleSort(), unsortedList);
            basePanel.Controls.Add(bubblePanel);
            var bubbleBwWorker = new BenchBackgroundWorker(bubblePanel);
			bubbleBwWorker.RunWorkerAsync();

			var insertionPanel = new BenchPanel(new InsertionSort(), unsortedList);
            basePanel.Controls.Add(insertionPanel);
			var insertionBwWorker = new BenchBackgroundWorker(insertionPanel);
			insertionBwWorker.RunWorkerAsync();

			var selectionPanel = new BenchPanel(new InsertionSort(), unsortedList);
            basePanel.Controls.Add(selectionPanel);
			var selectionBwWorker = new BenchBackgroundWorker(selectionPanel);
			selectionBwWorker.RunWorkerAsync();
		}
	}
}

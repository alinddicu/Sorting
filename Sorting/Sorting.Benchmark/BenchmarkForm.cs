namespace Sort.Benchmark
{
    using System.Linq;
    using System.Windows.Forms;

    using Sorting;
    using Sorting.Algorithms;

    public partial class BenchmarkForm : Form
    {
        public BenchmarkForm()
        {
            InitializeComponent();
            InitBenchWorkers();
        }

        private void InitBenchWorkers()
        {
            var sorts = new SortBase [] { new BubbleSort(), new InsertionSort(), new SelectionSort() };

            var basePanel = new FlowLayoutPanel { Dock = DockStyle.Fill };
            Controls.Add(basePanel);
            var unsortedList = new UniqueElementsGenerator().Execute(100).ToArray();

            foreach (var sort in sorts)
            {
                var bubblePanel = new BenchPanel(sort, unsortedList);
                basePanel.Controls.Add(bubblePanel);
                var bubbleBwWorker = new BenchBackgroundWorker(bubblePanel);
                bubbleBwWorker.RunWorkerAsync();
            }
        }
    }
}

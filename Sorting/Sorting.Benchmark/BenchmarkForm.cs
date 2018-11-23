namespace Sort.Benchmark
{
    using System.Linq;
    using System.Windows.Forms;

    using Sorting;
    using System.Reflection;
    using System.Collections.Generic;

    public partial class BenchmarkForm : Form
    {
        private readonly List<string> _sortRanking = new List<string>();
        private readonly int _maxSortValue;

        public BenchmarkForm(int maxSortValue)
        {
            _maxSortValue = maxSortValue;
            InitializeComponent();
            InitForm();
            InitBenchWorkers();
        }

        private void InitForm()
        {
            Width = 445;
            Height = 450;
            CenterToScreen();
        }

        private void InitBenchWorkers()
        {
            var sorts = Assembly.GetAssembly(typeof(SortBase)).GetEnumerableOfType<SortBase>();
            var basePanel = new FlowLayoutPanel
            {
                Width = Width,
                Height = Height,
                Dock = DockStyle.Fill
            };
            Controls.Add(basePanel);
            var unsortedList = new UniqueElementsGenerator().Execute(_maxSortValue).ToArray();

            foreach (var sort in sorts)
            {
                var bubblePanel = new BenchPanel(sort, unsortedList);
                basePanel.Controls.Add(bubblePanel);
                var bubbleBwWorker = new BenchBackgroundWorker(bubblePanel, _maxSortValue, _sortRanking);
                bubbleBwWorker.RunWorkerAsync();
            }
        }
    }
}

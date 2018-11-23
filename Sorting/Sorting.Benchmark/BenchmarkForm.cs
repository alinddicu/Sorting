﻿namespace Sort.Benchmark
{
    using System.Linq;
    using System.Windows.Forms;

    using Sorting;
    using Sorting.Algorithms;
    using System.Collections.Generic;
    using System;
    using System.Reflection;
    using Sorting;

    public partial class BenchmarkForm : Form
    {
        private readonly int _maxSortValue;

        public BenchmarkForm(int maxSortValue)
        {
            InitializeComponent();
            Width = 650;
            Height = 650;
            _maxSortValue = maxSortValue;
            InitBenchWorkers();
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
                var bubbleBwWorker = new BenchBackgroundWorker(bubblePanel, _maxSortValue);
                bubbleBwWorker.RunWorkerAsync();
            }
        }
    }
}

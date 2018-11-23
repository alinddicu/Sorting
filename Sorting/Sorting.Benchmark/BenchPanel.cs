namespace Sort.Benchmark
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using Sorting;
    using System.Drawing;

    public class BenchPanel : Panel
    {
        public BenchPanel(SortBase sortBase, IEnumerable<int> unsortedList)
        {
            Height = 200;
            Width = 200;
            BackColor = Color.Black;

            var sortName = sortBase.GetType().Name;
            var sortNameLabel = new Label()
            {
                Name = "SortNameLabel",
                Text = sortName,
                ForeColor = Color.Transparent,
                Height = 12,
                //Width = sortName.Length * 10
            };
            Controls.Add(sortNameLabel);

            var controlLabel = new Label()
            {
                Name = "ControlLabel",
                ForeColor = Color.Transparent,
                Location = new Point(0, sortNameLabel.Height + 1),
                Height = 12,
                Width = 10
            };
            Controls.Add(controlLabel);

            sortBase.Execute(unsortedList.ToArray());
            IntermediateSorts = sortBase.IntermediateSorts;
            SortName = sortBase.GetType().Name;

        }

        public List<ICollection<int>> IntermediateSorts { get; private set; }

        public string SortName { get; private set; }
    }
}

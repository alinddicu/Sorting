namespace Sort.Benchmark
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using Sorting;
    using System.Drawing;

    public class BenchPanel: Panel
	{
		public BenchPanel(SortBase sortBase, IEnumerable<int> unsortedList)
		{
			Height = 200;
			Width = 200;
            BackColor = Color.Black;
            var label = new Label()
            {
                Text = sortBase.GetType().Name,
                ForeColor = Color.Transparent
            };
            Controls.Add(label);
            sortBase.Execute(unsortedList.ToArray());
			IntermediateSorts = sortBase.IntermediateSorts;
		}

		public List<ICollection<int>> IntermediateSorts { get; private set; }
	}
}

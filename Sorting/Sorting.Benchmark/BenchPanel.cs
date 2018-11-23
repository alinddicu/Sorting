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
			Height = 100;
			Width = 100;
            BackColor = Color.Black;
            sortBase.Execute(unsortedList.ToArray());
			IntermediateSorts = sortBase.IntermediateSorts;
		}

		public List<ICollection<int>> IntermediateSorts { get; private set; }
	}
}

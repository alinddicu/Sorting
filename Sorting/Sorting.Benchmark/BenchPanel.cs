namespace Sort.Benchmark
{
	using System.Collections.Generic;
	using System.Drawing;
	using System.Linq;
	using System.Threading;
	using System.Windows.Forms;
	using Sorting;

	public class BenchPanel: Panel
	{
		public BenchPanel(SortBase sortBase, IEnumerable<int> unsortedList)
		{
			Height = 100;
			Width = 100;
			sortBase.Execute(unsortedList.ToArray());
			IntermediateSorts = sortBase.IntermediateSorts;
		}

		public List<ICollection<int>> IntermediateSorts { get; private set; }
	}
}

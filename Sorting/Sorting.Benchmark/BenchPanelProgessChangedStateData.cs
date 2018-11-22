namespace Sort.Benchmark
{
	using System.Collections.Generic;

	public class BenchPanelProgessChangedStateData
	{
		public BenchPanelProgessChangedStateData(ICollection<int> intermediateSort)
		{
			IntermediateSort = intermediateSort;
		}

		public ICollection<int> IntermediateSort { get; private set; }
	}
}
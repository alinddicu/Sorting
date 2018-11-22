namespace Sort.Benchmark
{
	using System.Collections.Generic;

	public class BenchProgessChanged
	{
		public BenchProgessChanged(ICollection<int> intermediateSort)
		{
			IntermediateSort = intermediateSort;
		}

		public ICollection<int> IntermediateSort { get; private set; }
	}
}
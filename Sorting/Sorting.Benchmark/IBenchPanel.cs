namespace Sort.Benchmark
{
	using System.Collections.Generic;

	public interface IBenchPanel
	{
		List<ICollection<int>> IntermediateSorts { get; }
		int Width { get; set; }
		int Height { get; set; }
		void DrawIntermediateSort(int progressPercentage);
		void Init(IEnumerable<int> unsortedList);
		void SetSortRanks();
	}
}
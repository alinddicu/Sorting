namespace Sorting
{
	using System.Collections.Generic;

	public abstract class SortBase
	{
		public List<ICollection<int>> IntermediateSorts { get; private set; } = new List<ICollection<int>>();

		public abstract IEnumerable<int> Execute(IEnumerable<int> unsortedList);

		protected IEnumerable<int> Copy(IEnumerable<int> input)
		{
			foreach (var item in input)
			{
				yield return item;
			}
		}
	}
}

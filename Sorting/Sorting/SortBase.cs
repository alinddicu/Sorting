namespace Sorting
{
    using System;
    using System.Linq;
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

        protected void AddToIntermediateSorts(IEnumerable<int> intermediatSort)
        {
            IntermediateSorts.Add(Copy(intermediatSort).ToList());
        }

        protected void Log(ICollection<int> collection)
        {
            Console.WriteLine("[" + string.Join(", ", collection) + "]");
        }
	}
}

namespace Sorting.Algorithms
{
    using System.Collections.Generic;
	using System.Linq;

	public class SelectionSort: SortBase
	{
		public override IEnumerable<int> Execute(ICollection<int> unsortedList)
		{
			base.Execute(unsortedList);
			var sortedList = Copy(unsortedList).ToList();
			AddToIntermediateSorts(unsortedList);

			var count = sortedList.Count;
			for (var i = count - 1; i >= 0; i--)
			{
				var minValue = GetMin(sortedList, i);
				sortedList.RemoveAt(minValue.Position);
				sortedList.Add(minValue.Value);

                AddToIntermediateSorts(sortedList);
            }

			StopWatch();
			return sortedList;
		}

		private static MinValue GetMin(IList<int> values, int limit)
		{
			var position = 0;
			var min = values[position];
			for (var i = 0; i <= limit; i++)
			{
				var item = values[i];
				if (item >= min)
				{
					continue;
				}

				min = item;
				position = i;
			}

			return new MinValue(min, position);
		}

		private class MinValue
		{
			public MinValue(int value, int position)
			{
				Value = value;
				Position = position;
			}

			public int Value { get; private set; }

			public int Position { get; private set; }
		}
	}
}

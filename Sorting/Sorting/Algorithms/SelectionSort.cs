namespace Sorting.Algorithms
{
	using System.Collections.Generic;
	using System.Linq;

	public class SelectionSort
	{
		public IEnumerable<int> Execute(IEnumerable<int> unsortedList)
		{
			var sortedList = Copy(unsortedList).ToList();
			var count = sortedList.Count;

			for (int i = count - 1; i >= 0; i--)
			{
				var minValue = GetMin(sortedList, i);
				sortedList.RemoveAt(minValue.Position);
				sortedList.Add(minValue.Value);
			}

			return sortedList;
		}
		private IEnumerable<int> Copy(IEnumerable<int> input)
		{
			foreach (var item in input)
			{
				yield return item;
			}
		}

		private MinValue GetMin(IList<int> values, int limit)
		{
			var position = 0;
			var min = values[position];
			for (int i = 0; i <= limit; i++)
			{
				var item = values[i];
				if (item < min)
				{
					min = item;
					position = i;
				}
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

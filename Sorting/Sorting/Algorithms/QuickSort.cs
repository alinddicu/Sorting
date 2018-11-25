namespace Sorting.Algorithms
{
	using System.Collections.Generic;
	using System.Linq;

	public class QuickSort : SortBase
	{
		private int[] _copy;

		// https://www.geeksforgeeks.org/quick-sort/
		public override IEnumerable<int> Execute(IEnumerable<int> unsortedList)
		{
			_copy = Copy(unsortedList).ToArray();
			AddToIntermediateSorts(_copy);

			Quicksort(_copy, 0, _copy.Length - 1);

			return _copy;
		}

		private void Quicksort(IList<int> array, int lo, int hi)
		{
			if (lo < hi)
			{
				var pivot = Partition(array, lo, hi);
				Quicksort(array, lo, pivot - 1);
				Quicksort(array, pivot + 1, hi);
			}
		}

		private int Partition(IList<int> array, int lo, int hi)
		{
			var pivot = array[hi];
			var i = lo - 1;
			for (var j = lo; j <= hi - 1; j++)
			{
				if (array[j] <= pivot)
				{
					i++;
					Swap(array, i, j);
				}
			}

			Swap(array, i + 1, hi);
			AddToIntermediateSorts(_copy);
			return i + 1;
		}

		private void Swap(IList<int> array, int i, int j)
		{
			var temp = array[j];
			array[j] = array[i];
			array[i] = temp;
		}
	}
}

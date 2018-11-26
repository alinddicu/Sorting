namespace Sorting.Algorithms
{
	using System.Collections.Generic;
	using System.Linq;

	public class MergeSort: SortBase
	{
		private int[] _copy;

		public override IEnumerable<int> Execute(ICollection<int> unsortedList)
		{
			base.Execute(unsortedList);
			_copy = Copy(unsortedList).ToArray();
			AddToIntermediateSorts(_copy);
			
			TopDownMergeSort(_copy, new int[_copy.Length], _copy.Length);

			StopWatch();
			return _copy;
		}
		
		private void TopDownMergeSort(int[] a, int[] b, int n)
		{
			CopyArray(a, 0, n, b);
			TopDownSplitMerge(b, 0, n, a);
		}

		private void TopDownSplitMerge(int[] b, int iBegin, int iEnd, int[] a)
		{
			if (iEnd - iBegin < 2)
			{
				return;
			}

			var iMiddle = (iEnd + iBegin) / 2;

			TopDownSplitMerge(a, iBegin, iMiddle, b);
			TopDownSplitMerge(a, iMiddle, iEnd, b);
			
			TopDownMerge(b, iBegin, iMiddle, iEnd, a);
		}

		private void TopDownMerge(int[] a, int iBegin, int iMiddle, int iEnd, int[] b)
		{
			var i = iBegin;
			var j = iMiddle;
			
			for (var k = iBegin; k < iEnd; k++)
			{
				if (i < iMiddle && (j >= iEnd || a[i] <= a[j]))
				{
					b[k] = a[i];
					i = i + 1;
				}
				else
				{
					b[k] = a[j];
					j = j + 1;
				}
			}

			AddToIntermediateSorts(_copy);
		}

		private void CopyArray(int[] a, int iBegin, int iEnd, int[] b)
		{
			for (var k = iBegin; k < iEnd; k++)
			{
				b[k] = a[k];
			}
		}
	}
}

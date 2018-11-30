namespace Sorting.Algorithms
{
	using System.Collections.Generic;
	using System.Linq;

	//https://www.geeksforgeeks.org/heap-sort/
	public class HeapSort: SortBase
	{
		private int[] _copy;

		public HeapSort(RankingSystem rankingSystem) : base(rankingSystem)
		{
		}

		public override IEnumerable<int> Execute(ICollection<int> unsortedList)
		{
			base.Execute(unsortedList);
			_copy = Copy(unsortedList).ToArray();
			AddToIntermediateSorts(_copy);
			
			Sort(_copy);

			StopWatch();
			return _copy;
		}

		private void Sort(IList<int> arr)
		{
			var n = arr.Count;

			// Build heap (rearrange array) 
			for (var i = n/2 - 1; i >= 0; i--)
			{
				Heapify(arr, n, i);
				AddToIntermediateSorts(_copy);
			}

			// One by one extract an element from heap 
			for (var i = n - 1; i >= 0; i--)
			{
				// Move current root to end 
				var temp = arr[0];
				arr[0] = arr[i];
				arr[i] = temp;

				// call max heapify on the reduced heap 
				Heapify(arr, i, 0);
				AddToIntermediateSorts(_copy);
			}
		}

		// To heapify a subtree rooted with node i which is 
		// an index in arr[]. n is size of heap 
		private static void Heapify(IList<int> arr, int n, int i)
		{
			while (true)
			{
				var largest = i; // Initialize largest as root 
				var l = 2*i + 1; // left = 2*i + 1 
				var r = 2*i + 2; // right = 2*i + 2 

				// If left child is larger than root 
				if (l < n && arr[l] > arr[largest])
					largest = l;

				// If right child is larger than largest so far 
				if (r < n && arr[r] > arr[largest])
					largest = r;

				// If largest is not root 
				if (largest == i)
				{
					return;
				}

				var swap = arr[i];
				arr[i] = arr[largest];
				arr[largest] = swap;

				// Recursively heapify the affected sub-tree 
				i = largest;
			}
		}
	}
}

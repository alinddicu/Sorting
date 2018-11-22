﻿namespace Sorting.Algorithms
{
	using System.Collections.Generic;

	public class InsertionSort : SortBase
	{
		public override IEnumerable<int> Execute(IEnumerable<int> unsortedList)
		{
			var sortedList = new List<int>();
			foreach (var unsortedItem in unsortedList)
			{
				var inserted = false;
				for (var i = sortedList.Count - 1; !inserted && i >= 0; i--)
				{
					var sortedItem = sortedList[i];
					int? sortedItemMinus1 = null;
					if (i != 0 && sortedList.Count >= 2)
					{
						sortedItemMinus1 = sortedList[i - 1];
					}

					if (unsortedItem < sortedItem && (!sortedItemMinus1.HasValue || unsortedItem > sortedItemMinus1))
					{
						sortedList.Insert(i, unsortedItem);
						inserted = true;
					}
				}

				if (!inserted)
				{
					sortedList.Add(unsortedItem);
                }

                IntermediateSorts.Add(sortedList);
            }

			return sortedList;
		}
	}
}

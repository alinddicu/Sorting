namespace Sorting.Algorithms
{
	using System.Linq;
	using System.Collections.Generic;

	public class BubbleSort: SortBase
	{
		public BubbleSort(RankingSystem rankingSystem): base(rankingSystem)
		{
		}

		public override IEnumerable<int> Execute(ICollection<int> unsortedList)
		{
			base.Execute(unsortedList);
			var sortedList = Copy(unsortedList).ToArray();
			AddToIntermediateSorts(sortedList);

			bool inversion;
			do
			{
				inversion = false;
				for (var i = 0; i < sortedList.Length - 1; i++)
				{
					var left = sortedList[i];
					var right = sortedList[i + 1];
					if (left > right)
					{
						sortedList[i] = right;
						sortedList[i + 1] = left;
						inversion = true;
                        AddToIntermediateSorts(sortedList);
                    }
				}
			} while (inversion);

			StopWatch();
			return sortedList;
		}
	}
}

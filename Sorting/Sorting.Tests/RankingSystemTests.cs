namespace Sorting.Tests
{
	using System.Collections.Generic;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using NFluent;

	[TestClass]
	public class RankingSystemTests
	{
		[TestMethod]
		public void Given2PositionsWhenClearThenGetThrowException()
		{
			var rankingSystem = new RankingSystem(0);

			rankingSystem.Add("BubbleSort", 1);
			rankingSystem.Add("QuickSort", 2);

			rankingSystem.Clear();

			Check.ThatCode(() => rankingSystem.Get("BubbleSort")).Throws<KeyNotFoundException>();
			Check.ThatCode(() => rankingSystem.Get("QuickSort")).Throws<KeyNotFoundException>();
			Check.ThatCode(() => rankingSystem.Get("MergeSort")).Throws<KeyNotFoundException>();
		}

		[TestMethod]
		public void Given2PositionWhenGetThenReturnTheCorrectRank()
		{
			var rankingSystem = new RankingSystem(2);

			rankingSystem.Add("BubbleSort", 5);
			rankingSystem.Add("QuickSort", 6);

			Check.That(rankingSystem.Get("QuickSort")).IsEqualTo(2);
			Check.That(rankingSystem.Get("BubbleSort")).IsEqualTo(1);
			Check.ThatCode(() => rankingSystem.Get("MergeSort")).Throws<KeyNotFoundException>();
		}

		[TestMethod]
		public void Given3PositionsButOnly2SortingsWhenGetThenReturnNullForAllSortings()
		{
			var rankingSystem = new RankingSystem(2);

			rankingSystem.Add("BubbleSort", 5);
			rankingSystem.Add("QuickSort", 6);
			rankingSystem.Add("MergeSort", 7);

			Check.That(rankingSystem.Get("QuickSort")).IsNull();
			Check.That(rankingSystem.Get("BubbleSort")).IsNull();
			Check.That(rankingSystem.Get("MergeSort")).IsNull();
		}
	}
}

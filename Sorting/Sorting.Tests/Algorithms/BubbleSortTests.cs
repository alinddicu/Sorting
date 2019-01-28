namespace Sorting.Tests.Algorithms
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using NFluent;
	using Sorting.Algorithms;
	using System.Linq;

	[TestClass]
	public class BubbleSortTests
	{
		[TestMethod]
		public void GivenBubbleWhenExecuteThenResultIsOrdered()
		{
			var topLimit = 100;
			var expected = Enumerable.Range(1, topLimit).ToArray();
			var testArray = new UniqueElementsGenerator().Execute(topLimit).ToArray();
			var result = new BubbleSort(new RankingSystem(1)).Execute(testArray).ToArray();

			Check.That(result).IsEqualTo(expected);
		}
	}
}

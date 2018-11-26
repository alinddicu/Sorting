namespace Sorting.Tests.Algorithms
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using NFluent;
	using Sorting.Algorithms;
	using System.Linq;

	[TestClass]
	public class QuickSortTests
    {
		[TestMethod]
		public void GivenQuickSortWhenExecuteThenResultIsOrdered()
		{
			var topLimit = 5;
			var expected = Enumerable.Range(1, topLimit).ToArray();
			var testArray = new UniqueElementsGenerator().Execute(topLimit).ToArray();
			var result = new QuickSort().Execute(testArray).ToArray();

			Check.That(result).IsEqualTo(expected);
		}
	}
}

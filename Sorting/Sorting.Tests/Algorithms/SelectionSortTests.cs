namespace Sorting.Tests.Algorithms
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using NFluent;
	using Sorting.Algorithms;
	using System.Linq;

	[TestClass]
	public class SelectionSortTests
	{

		[TestMethod]
		public void GivenSelectionWhenExecuteThenResultIsOrdered()
		{
			var topLimit = 100;
			var expected = Enumerable.Range(1, topLimit).ToArray();
			var testArray = new NoDoublesGenerator().Execute(topLimit);
			//var testArray = new[] { 5, 4, 3, 2, 1 };
			var result = new SelectionSort().Execute(testArray).ToArray();

			Check.That(result).IsEqualTo(expected);
		}
	}
}

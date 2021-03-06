﻿namespace Sorting.Tests.Algorithms
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using NFluent;
	using Sorting.Algorithms;
	using System.Linq;

	[TestClass]
	public class InsertionSortTests
	{

		[TestMethod]
		public void GivenInsertionWhenExecuteThenResultIsOrdered()
		{
			var topLimit = 100;
			var expected = Enumerable.Range(1, topLimit).ToArray();
			var testArray = new UniqueElementsGenerator().Execute(topLimit).ToArray();
			//var testArray = new[] { 5, 4, 3, 2, 1 };
			var result = new InsertionSort(new RankingSystem(1)).Execute(testArray).ToArray();

			Check.That(result).IsEqualTo(expected);
		}
	}
}

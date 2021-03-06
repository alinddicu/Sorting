﻿namespace Sorting.Tests
{
	using System.Linq;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using NFluent;

	[TestClass]
	public class UniqueElementsGeneratorTest
	{
		[TestMethod]
		public void GivenFrom1To100WhenExecuteThanSequenceIsCorrect()
		{
			var array = new UniqueElementsGenerator().Execute(100);

			Check.That(array.Sum(i => i)).IsEqualTo(5050);
		}
	}
}

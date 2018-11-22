namespace Sorting.Tests
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;
    using Sorting.Algorithms;
    using System.Collections.Generic;

    [TestClass]
    public class GlobalAlgorithmsTests
    {
        [TestMethod]
        public void GlobalSortingsTests()
        {
            var topLimit = 500;
            var expected = Enumerable.Range(1, topLimit).ToArray();
            var testArray = new UniqueElementsGenerator().Execute(topLimit);
            var algorithms = new List<SortBase>()
            {
                new BubbleSort(),
                new InsertionSort(),
                new SelectionSort()
            };

            var results = algorithms.Select(a => a.Execute(testArray));

            Check.That(results.All(r => r.SequenceEqual(expected))).IsTrue();
        }
    }
}

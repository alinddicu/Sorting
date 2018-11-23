namespace Sorting.Tests
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;
    using System.Reflection;

    [TestClass]
    public class GlobalAlgorithmsTests
    {
        [TestMethod]
        public void GlobalSortingsTests()
        {
            var topLimit = 500;
            var expected = Enumerable.Range(1, topLimit).ToArray();
            var testArray = new UniqueElementsGenerator().Execute(topLimit);
            var algorithms = Assembly.GetAssembly(typeof(SortBase)).GetEnumerableOfType<SortBase>();

            var results = algorithms.Select(a => a.Execute(testArray));

            Check.That(results.All(r => r.SequenceEqual(expected))).IsTrue();
        }
    }
}

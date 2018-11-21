using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace Sorting.Tests
{
	[TestClass]
	public class NoDoublesGeneratorTest
	{
		[TestMethod]
		public void GivenFrom1To100WhenExecuteThanSequenceIsCorrect()
		{
			var array = new NoDoublesGenerator().Execute(100);

			Check.That(array.Sum(i => i)).IsEqualTo(5050);
		}
	}
}

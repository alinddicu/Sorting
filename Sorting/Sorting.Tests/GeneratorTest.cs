using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace Sorting.Tests
{
	[TestClass]
	public class GeneratorTest
	{
		[TestMethod]
		public void GivenFrom1To100WhenExecuteThanSequenceIsCorrect()
		{
			var array = new NoDoublesGenerator().Execute();

			Check.That(array.Sum(i => i)).IsEqualTo(5050);
		}
	}
}

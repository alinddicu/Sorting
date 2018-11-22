namespace Sorting
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class NoDoublesGenerator
    {
		public IEnumerable<int> Execute(int topLimit)
		{
			var rnd = new Random();
			return Enumerable.Range(1, topLimit).OrderBy(x => rnd.Next());
		}
    }
}

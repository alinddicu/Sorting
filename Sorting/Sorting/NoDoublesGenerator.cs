namespace Sorting
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Medallion;

	public class NoDoublesGenerator
    {
		public IEnumerable<int> Execute()
		{
			//var rnd = new Random();
			//return Enumerable.Range(1, 100).OrderBy(x => rnd.Next());
			return Enumerable.Range(1, 100).Shuffled(new Random()).ToArray();
		}
    }
}

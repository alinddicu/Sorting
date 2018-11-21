namespace Sorting.Algorithms
{
	using System.Linq;
	using System;
	using System.Collections.Generic;

	public class Bubble
	{
		public IEnumerable<int> Execute(IEnumerable<int> input)
		{
			var copy = Copy(input).ToArray();
			var inversion = false;

			do
			{
				inversion = false;
				for (int i = 0; i < copy.Length - 1; i++)
				{
					var left = copy[i];
					var right = copy[i + 1];
					if (left > right)
					{
						copy[i] = right;
						copy[i + 1] = left;
						inversion = true;
					}
				}
			} while (inversion);

			return copy;
		}

		private IEnumerable<int> Copy(IEnumerable<int> input)
		{
			foreach (var item in input)
			{
				yield return item;
			}
		}
	}
}

namespace Sorting
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Diagnostics;

	public abstract class SortBase
	{
		private Stopwatch _stopWatch;
		
		public List<ICollection<int>> IntermediateSorts { get; } = new List<ICollection<int>>();

		public long Duration { get; private set; }

		public virtual IEnumerable<int> Execute(ICollection<int> unsortedList)
		{
			_stopWatch = Stopwatch.StartNew();
			IntermediateSorts.Clear();
			return unsortedList;
		}

		protected void StopWatch()
		{
			_stopWatch.Stop();
			Duration = _stopWatch.ElapsedTicks;
		}

		protected IEnumerable<int> Copy(IEnumerable<int> input)
		{
			foreach (var item in input)
			{
				yield return item;
			}
		}

        protected void AddToIntermediateSorts(IEnumerable<int> intermediatSort)
        {
            IntermediateSorts.Add(Copy(intermediatSort).ToList());
        }

        protected void Log(ICollection<int> collection)
        {
            Console.WriteLine("[" + string.Join(", ", collection) + "]");
        }
	}
}

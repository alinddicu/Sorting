namespace Sorting
{
	using System.Collections.Generic;
	using System.Linq;

	public class RankingSystem
	{
		private readonly List<Position> _ranking = new List<Position>();

		public void Clear()
		{
			_ranking.Clear();
		}

		public void Add(string sortName, long duration)
		{
			_ranking.Add(new Position(sortName, duration));
		}

		public int Get(string sortName)
		{
			return _ranking
				.OrderBy(position => position.Duration)
				.Select((position, index) => new {P = position, Rank = index})
				.First(o => o.P.Name == sortName)
				.Rank + 1;
		}

		private class Position
		{
			public Position(string name, long duration)
			{
				Name = name;
				Duration = duration;
			}

			public string Name { get; private set; }

			public long Duration { get; private set; } 
		}
	}
}

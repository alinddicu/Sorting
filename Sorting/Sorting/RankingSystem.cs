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
			var rank = _ranking
				.OrderBy(position => position.Duration)
				.Select((position, index) => new { P = position, Rank = index })
				.FirstOrDefault(o => o.P.Name == sortName);

			if (rank == null)
			{
				throw new KeyNotFoundException($"Sort name '{sortName}' not found");
			}

			return rank.Rank + 1;
		}

		private class Position
		{
			public Position(string name, long duration)
			{
				Name = name;
				Duration = duration;
			}

			public string Name { get; }

			public long Duration { get; }
		}
	}
}

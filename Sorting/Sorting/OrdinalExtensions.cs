namespace Sorting
{
	using System;
	using System.Collections.Generic;

	public static class OrdinalExtensions
	{
		public static string ToOrdinal(this long number)
		{
			if (number < 0) return number.ToString();
			long rem = number % 100;
			if (rem >= 11 && rem <= 13) return number + "th";

			switch (number % 10)
			{
				case 1:
					return number + "st";
				case 2:
					return number + "nd";
				case 3:
					return number + "rd";
				default:
					return number + "th";
			}
		}

		public static string ToOrdinal(this int number)
		{
			return ((long)number).ToOrdinal();
		}

		public static string ToOrdinal(this string number)
		{
			if (string.IsNullOrEmpty(number)) return number;

			var dict = new Dictionary<string, string>
			{
				{"zero", "zeroth"},
				{"nought", "noughth"},
				{"one", "first"},
				{"two", "second"},
				{"three", "third"},
				{"four", "fourth"},
				{"five", "fifth"},
				{"six", "sixth"},
				{"seven", "seventh"},
				{"eight", "eighth"},
				{"nine", "ninth"},
				{"ten", "tenth"},
				{"eleven", "eleventh"},
				{"twelve", "twelfth"},
				{"thirteen", "thirteenth"},
				{"fourteen", "fourteenth"},
				{"fifteen", "fifteenth"},
				{"sixteen", "sixteenth"},
				{"seventeen", "seventeenth"},
				{"eighteen", "eighteenth"},
				{"nineteen", "nineteenth"},
				{"twenty", "twentieth"},
				{"thirty", "thirtieth"},
				{"forty", "fortieth"},
				{"fifty", "fiftieth"},
				{"sixty", "sixtieth"},
				{"seventy", "seventieth"},
				{"eighty", "eightieth"},
				{"ninety", "ninetieth"},
				{"hundred", "hundredth"},
				{"thousand", "thousandth"},
				{"million", "millionth"},
				{"billion", "billionth"},
				{"trillion", "trillionth"},
				{"quadrillion", "quadrillionth"},
				{"quintillion", "quintillionth"}
			};


			// rough check whether it's a valid number
			string temp = number.ToLower().Trim().Replace(" and ", " ");
			string[] words = temp.Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

			foreach (string word in words)
			{
				if (!dict.ContainsKey(word)) return number;
			}

			// extract last word
			number = number.TrimEnd().TrimEnd('-');
			var index = number.LastIndexOfAny(new[] { ' ', '-' });
			var last = number.Substring(index + 1);

			// make replacement and maintain original capitalization
			if (last == last.ToLower())
			{
				last = dict[last];
			}
			else if (last == last.ToUpper())
			{
				last = dict[last.ToLower()].ToUpper();
			}
			else
			{
				last = last.ToLower();
				last = char.ToUpper(dict[last][0]) + dict[last].Substring(1);
			}

			return number.Substring(0, index + 1) + last;
		}
	}
}

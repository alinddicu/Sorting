namespace Sort.Benchmark
{
	using System.Collections.Generic;
	using System.Drawing;
	using System.Linq;
	using System.Threading;
	using System.Windows.Forms;
	using Sorting;

	public class BenchPanel: Panel
	{
		private readonly SortBase _sort;
		private readonly int[] _unsortedList;

		public BenchPanel(SortBase sortBase, IEnumerable<int> unsortedList)
		{
			Height = 100;
			Width = 100;
			_sort = sortBase;
			_unsortedList = unsortedList.ToArray();
			Paint += PaintEventHandler;
		}

		private void PaintEventHandler(object sender, PaintEventArgs e)
		{
			_sort.Execute(_unsortedList);
			var pen = new Pen(Color.DarkGreen);

			var height = Height;
			var intermediateSorts = _sort.IntermediateSorts;
			foreach (var intermediateSort in intermediateSorts)
			{
				e.Graphics.Clear(BackColor);
				var numbers = intermediateSort.ToArray();
				for (var i = 0; i < numbers.Length; i++)
				{
					var x = i;
					var number = numbers[i];
					//e.Graphics.DrawRectangle(pen, i + 11, height, 10, number);
					e.Graphics.DrawLine(pen, x, height, x, height - number);
				}

				Thread.Sleep(10);
			}
		}
	}
}

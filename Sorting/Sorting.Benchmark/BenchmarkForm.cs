namespace Sort.Benchmark
{
	using System.Drawing;
	using System.Linq;
	using System.Threading;
	using System.Windows.Forms;

	using Sorting;
	using Sorting.Algorithms;

	public partial class BenchmarkForm : Form
	{
		public BenchmarkForm()
		{
			InitializeComponent();
		}

		private void panel_Paint(object sender, PaintEventArgs e)
		{
			var unsortedList = new UniqueElementsGenerator().Execute(100).ToArray();
			var bubble = new BubbleSort();
			bubble.Execute(unsortedList);

			panel.BackColor = Color.Black;
			var pen = new Pen(Color.DarkGreen);

			var height = panel.Height;
			var intermediateSorts = bubble.IntermediateSorts;
			foreach (var intermediateSort in intermediateSorts)
			{
				var numbers = intermediateSort.ToArray();
				for (var i = 0; i < numbers.Length; i++)
				{
					var x = i + 10;
					var number = numbers[i];
					//e.Graphics.DrawRectangle(pen, i + 11, height, 10, number);
					e.Graphics.DrawLine(pen, x, height, x, height - number);
				}

				Thread.Sleep(10);
				e.Graphics.Clear(panel.BackColor);
			}
		}
	}
}

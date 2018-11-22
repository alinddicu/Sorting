namespace Sort.Benchmark
{
	using System.Drawing;
	using System.Linq;
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

			var pen = new Pen(Color.Black);

			var numbers = bubble.IntermediateSorts.First().ToArray();
			var height = panel.Height;
			for (var i = 0; i < numbers.Length; i++)
			{
				var x = i;
				var number = numbers[i];
				e.Graphics.DrawLine(pen, x, height, x, height - number);
			}
		}
	}
}

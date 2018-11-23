namespace Sort.Benchmark
{
	using System.Collections.Generic;
	using System.Drawing;
	using System.Linq;
	using System.Windows.Forms;

	using Sorting;

	public class BenchPanel : FlowLayoutPanel
	{
		private static readonly Color BackColorConst = Color.Black;
		private static readonly Color ForeColorConst = Color.White;
		private static readonly Pen Pen = new Pen(Color.DarkGreen);

		private readonly Graphics _graphics;
		private readonly Panel _drawingPanel;
		private readonly int _maxSortValue;
		private readonly Label _sortNameLabel;

		public BenchPanel(SortBase sortBase, IEnumerable<int> unsortedList, int maxSortValue)
		{
			sortBase.Execute(unsortedList.ToArray());
			IntermediateSorts = sortBase.IntermediateSorts;
			var iterations = IntermediateSorts.Count;
			var sortName = sortBase.GetType().Name;
			_maxSortValue = maxSortValue;
			BackColor = BackColorConst;
			ForeColor = ForeColorConst;

			_drawingPanel = new Panel { Height = 200, Width = 200, BackColor = BackColorConst, ForeColor = ForeColorConst };
			var sortNameText = $"{sortName} - {iterations} iterations";
			var sortNameWidth = sortNameText.Length * 7;
			_sortNameLabel = new Label { Text = sortNameText, BackColor = BackColorConst, Height = 12, Width = sortNameWidth, ForeColor = ForeColorConst };
			Controls.AddRange(new Control[] { _sortNameLabel, _drawingPanel });
			Height = _drawingPanel.Height + _sortNameLabel.Height;

			SortName = sortName;
			_graphics = _drawingPanel.CreateGraphics();
			_drawingPanel.Paint += BenchPanel_Paint;
		}

		private void BenchPanel_Paint(object sender, PaintEventArgs e)
		{
			DrawIntermediateSort(e.Graphics, IntermediateSorts.Count - 1);
		}

		public List<ICollection<int>> IntermediateSorts { get; }

		public string SortName { get; private set; }

		private void DrawIntermediateSort(Graphics graphics, int intermediateSortIndex)
		{
			RefreshLabels();

			graphics.Clear(_drawingPanel.BackColor);
			var height = _drawingPanel.Height;
			var width = _drawingPanel.Width;

			var heightFactor = (double)height / _maxSortValue;
			var widthFactor = (double)width / _maxSortValue;

			var numbers = IntermediateSorts[intermediateSortIndex].ToArray();
			for (var i = 0; i < numbers.Length; i++)
			{
				var number = numbers[i];
				graphics.DrawLine(
					Pen,
					(int)widthFactor * i,
					height,
					(int)widthFactor * i,
					(int)(height - number * heightFactor));
			}
		}

		public void DrawIntermediateSort(int intermediateSortIndex)
		{
			DrawIntermediateSort(_graphics, intermediateSortIndex);
		}

		private void RefreshLabels()
		{
			// fix bug: colors don't apply to labels when initializing
			_sortNameLabel.Refresh();
		}
	}
}

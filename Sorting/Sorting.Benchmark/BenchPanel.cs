namespace Sort.Benchmark
{
	using System.Collections.Generic;
	using System.Drawing;
	using System.Linq;
	using System.Windows.Forms;

	using Sorting;

	public class BenchPanel : FlowLayoutPanel
	{
		private readonly Panel _drawingPanel;
		private readonly Label _rankLabel;
		private readonly int _maxSortValue;
		private readonly Label _sortNameLabel;

		public BenchPanel(SortBase sortBase, IEnumerable<int> unsortedList, int maxSortValue)
		{
			var sortName = sortBase.GetType().Name;
			_maxSortValue = maxSortValue;
			BackColor = Color.Black;
			ForeColor = Color.White;
		
			const int labelsWidth = 94;
			var backColor = Color.Black;
			var foreColor = Color.White;
			_drawingPanel = new Panel { Height = 200, Width = 200, BackColor = backColor, ForeColor = foreColor };
			_sortNameLabel = new Label { Text = sortName, BackColor = backColor, Height = 12, Width = labelsWidth, ForeColor = foreColor };
			_rankLabel = new Label { BackColor = backColor, Height = 12, Width = labelsWidth, ForeColor = foreColor, TextAlign = ContentAlignment.MiddleRight };
			Controls.AddRange(new Control[] { _sortNameLabel, _rankLabel, _drawingPanel });
			Height = _drawingPanel.Height + _sortNameLabel.Height;

			sortBase.Execute(unsortedList.ToArray());
			IntermediateSorts = sortBase.IntermediateSorts;
			SortName = sortName;
		}

		public List<ICollection<int>> IntermediateSorts { get; }

		public string SortName { get; private set; }

		public void UpdateRankLabel(string text)
		{
			_rankLabel.Text = text;
			_rankLabel.Refresh();
		}

		public void DrawIntermediateSort(int intermediateSortIndex)
		{
			// fix bug: colors don't apply to labels
			_sortNameLabel.Refresh();
			_rankLabel.Refresh();

			var graphics = _drawingPanel.CreateGraphics();
			graphics.Clear(_drawingPanel.BackColor);
			var numbers = IntermediateSorts[intermediateSortIndex].ToArray();
			var pen = new Pen(Color.DarkGreen);
			var height = _drawingPanel.Height;
			var width = _drawingPanel.Width;

			var heightFactor = (double)height / _maxSortValue;
			var widthFactor = (double)width / _maxSortValue;

			for (var i = 0; i < numbers.Length; i++)
			{
				var number = numbers[i];
				graphics.DrawLine(
					pen,
					(int)widthFactor * i,
					height,
					(int)widthFactor * i,
					(int)(height - number * heightFactor));
			}
		}
	}
}

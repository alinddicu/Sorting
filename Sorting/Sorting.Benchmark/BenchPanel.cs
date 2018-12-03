namespace Sort.Benchmark
{
	using System.Collections.Generic;
	using System.Drawing;
	using System.Linq;
	using System.Windows.Forms;

	using Sorting;

	public class BenchPanel : FlowLayoutPanel, IBenchPanel
	{
		private static readonly Color BackColorConst = Color.Black;
		private static readonly Color ForeColorConst = Color.White;
		private static readonly Pen Pen = new Pen(Color.DarkGreen);

		private readonly Graphics _graphics;
		private readonly Panel _drawingPanel;
		private readonly SortBase _sortBase;
		private readonly int _maxSortValue;
		private readonly Label _sortNameLabel;
		private int _lastIntermediateSortIndex;

		public BenchPanel(SortBase sortBase, IEnumerable<int> unsortedList, int maxSortValue)
		{
			_sortBase = sortBase;
			_maxSortValue = maxSortValue;
			BackColor = BackColorConst;
			ForeColor = ForeColorConst;

			_drawingPanel = new Panel { Height = 200, Width = 200, BackColor = BackColorConst, ForeColor = ForeColorConst };
			_sortNameLabel = new Label { BackColor = BackColorConst, Height = 12, ForeColor = ForeColorConst };
			Controls.AddRange(new Control[] { _sortNameLabel, _drawingPanel });
			Height = _drawingPanel.Height + _sortNameLabel.Height;
			Init(unsortedList);

			_graphics = _drawingPanel.CreateGraphics();
			_drawingPanel.Paint += BenchPanel_Paint;
		}

		public void Init(IEnumerable<int> unsortedList)
		{
			_sortBase.Execute(unsortedList.ToArray());
			IntermediateSorts = _sortBase.IntermediateSorts;
		}

		private void BenchPanel_Paint(object sender, PaintEventArgs e)
		{
			DrawIntermediateSort(e.Graphics, _lastIntermediateSortIndex);
		}

		public List<ICollection<int>> IntermediateSorts { get; private set; }

		private void DrawIntermediateSort(Graphics graphics, int intermediateSortIndex)
		{
			_lastIntermediateSortIndex = intermediateSortIndex;
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

		public void SetSortRanks()
		{
			var sortName = _sortBase.GetType().Name;
			var rank = _sortBase.Rank.ToOrdinal();
			var sortNameText = $"{sortName} - {rank} ({_sortBase.Duration} ticks)";
			var sortNameWidth = sortNameText.Length * 7;
			_sortNameLabel.Text = sortNameText;
			_sortNameLabel.Width = sortNameWidth;
			//_sortNameLabel.Refresh();
		}
	}
}

namespace Sort.Benchmark
{
	using System;
	using System.Windows.Forms;

	public partial class OptionsForm : Form
	{
		private readonly BenchmarkForm _benchmarkForm;

		public OptionsForm(BenchmarkForm benchmarkForm, int maxValuesToSort, int drawDelay)
		{
			_benchmarkForm = benchmarkForm;
			InitializeComponent();
			CenterToScreen();

			maxValuesToSortTrackBar.Minimum = 100;
			maxValuesToSortTrackBar.Maximum = 1200;
			maxValuesToSortTrackBar.Value = maxValuesToSort;
			maxValuesToSortTrackBar.LargeChange = 100;
			maxValuesToSortTrackBar.SmallChange = 100;
			maxValuesToSortTrackBar.TickFrequency = 100;
			maxValuesToSortTrackBar.Scroll += MaxValuesToSortTrackBar_Scroll;

			drawDelayTrackBar.Minimum = 50;
			drawDelayTrackBar.Maximum = 1000;
			drawDelayTrackBar.Value = drawDelay;
			drawDelayTrackBar.LargeChange = 50;
			drawDelayTrackBar.SmallChange = 50;
			drawDelayTrackBar.TickFrequency = 100;
			drawDelayTrackBar.Scroll += DrawDelayTrackBar_Scroll;
		}

		private void DrawDelayTrackBar_Scroll(object sender, EventArgs e)
		{
			DiscretizeTrackBarValue(sender as TrackBar);
		}

		private void MaxValuesToSortTrackBar_Scroll(object sender, EventArgs e)
		{
			DiscretizeTrackBarValue(sender as TrackBar);
		}

		private void DiscretizeTrackBarValue(TrackBar trackBar)
		{
			var largeChange = trackBar.LargeChange;
			trackBar.Value = trackBar.Value / largeChange * largeChange;
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			Close();
			_benchmarkForm.UpdateOptions(maxValuesToSortTrackBar.Value, drawDelayTrackBar.Value);
		}
	}
}

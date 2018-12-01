namespace Sort.Benchmark
{
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

			drawDelayTrackBar.Minimum = 50;
			drawDelayTrackBar.Maximum = 1000;
			drawDelayTrackBar.Value = drawDelay;
			drawDelayTrackBar.LargeChange = 50;
			drawDelayTrackBar.SmallChange = 50;
			drawDelayTrackBar.TickFrequency = 100;
		}

		private void cancelButton_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void saveButton_Click(object sender, System.EventArgs e)
		{
			Close();
			_benchmarkForm.UpdateOptions(maxValuesToSortTrackBar.Value, drawDelayTrackBar.Value);
		}
	}
}

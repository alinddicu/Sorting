namespace Sorting.Benchmark.Tests
{
	using System.Windows.Forms;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using NFluent;
	using Sort.Benchmark;

	[TestClass]
	public class OptionsFormTests
	{
		[TestMethod]
		public void GivenOptionsFormWhenNewThenTrackBarOptionsAreAsIntended()
		{
			var benchmarkForm = new BenchmarkForm();
			const int maxValuesToSort = 100;
			const int drawDelay = 200;
			var optionsForm = new OptionsForm(benchmarkForm, maxValuesToSort, drawDelay);

			var maxValuesToSortTrackBar = (TrackBar)optionsForm.Controls.Find("maxValuesToSortTrackBar", true)[0];
			Check.That(maxValuesToSortTrackBar.Minimum).IsEqualTo(100);
			Check.That(maxValuesToSortTrackBar.Maximum).IsEqualTo(1200);
			Check.That(maxValuesToSortTrackBar.Value).IsEqualTo(maxValuesToSort);
			Check.That(maxValuesToSortTrackBar.LargeChange).IsEqualTo(100);
			Check.That(maxValuesToSortTrackBar.SmallChange).IsEqualTo(100);
			Check.That(maxValuesToSortTrackBar.TickFrequency).IsEqualTo(100);

			var drawDelayTrackBar = (TrackBar)optionsForm.Controls.Find("drawDelayTrackBar", true)[0];
			Check.That(drawDelayTrackBar.Minimum).IsEqualTo(50);
			Check.That(drawDelayTrackBar.Maximum).IsEqualTo(1000);
			Check.That(drawDelayTrackBar.Value).IsEqualTo(drawDelay);
			Check.That(drawDelayTrackBar.LargeChange).IsEqualTo(50);
			Check.That(drawDelayTrackBar.SmallChange).IsEqualTo(50);
			Check.That(drawDelayTrackBar.TickFrequency).IsEqualTo(100);
		}

		[TestMethod]
		public void GivenOptionsFormWhenModifyValuesThenNewValuesAreUpdatedInBenchmarkForm()
		{
			var benchmarkForm = new BenchmarkForm();
			const int maxValuesToSort = 100;
			const int drawDelay = 200;
			var optionsForm = new OptionsForm(benchmarkForm, maxValuesToSort, drawDelay);

			var maxValuesToSortTrackBar = (TrackBar)optionsForm.Controls.Find("maxValuesToSortTrackBar", true)[0];
			maxValuesToSortTrackBar.Value = 150;
			var drawDelayTrackBar = (TrackBar)optionsForm.Controls.Find("drawDelayTrackBar", true)[0];
			drawDelayTrackBar.Value = 250;

			var saveButton = (Button)optionsForm.Controls.Find("saveButton", true)[0];

			optionsForm.Show();
			saveButton.PerformClick();

			Check.That(benchmarkForm.NewMaxValuesToSort).IsEqualTo(150);
			Check.That(benchmarkForm.NewDrawDelay).IsEqualTo(250);
		}

		private class BenchmarkForm : IBenchmarkForm
		{
			public void UpdateOptions(int maxValuesToSort, int drawDelay)
			{
				NewMaxValuesToSort = maxValuesToSort;
				NewDrawDelay = drawDelay;
			}

			public int NewMaxValuesToSort { get; private set; }

			public int NewDrawDelay { get; private set; }
		}
	}
}

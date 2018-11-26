namespace Sort.Benchmark
{
	using System;
	using System.Windows.Forms;

	public static class Program
	{
        private static readonly int MaxSortValue = 200;

        [STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new BenchmarkForm(MaxSortValue));
		}
	}
}

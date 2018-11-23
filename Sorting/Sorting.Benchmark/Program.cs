﻿namespace Sort.Benchmark
{
	using System;
	using System.Windows.Forms;

	public static class Program
	{
        private static readonly int MaxSortValue = 200;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
		public static void Main()
		{
			//new Benchmark().Execute();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new BenchmarkForm(MaxSortValue));
		}
	}
}

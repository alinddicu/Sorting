namespace Sort.Benchmark
{
	internal interface IBenchBackgroundWorker
	{
		void ReportProgress(int i);
		IBenchPanel BenchPanel { get; }
		void SetDrawDelay(int drawDelay);
		void RunWorkerAsync();
		void CancelAsync();
	}
}
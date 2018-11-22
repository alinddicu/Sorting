namespace Sort.Benchmark
{
	using System.Linq;

	using Sorting;
	using Sorting.Algorithms;

	public class Benchmark
    {
	    public void Execute()
	    {
			var unsortedList = new NoDoublesGenerator().Execute(100).ToArray();
            var bubble = new BubbleSort();
            bubble.Execute(unsortedList);
            var insertion = new InsertionSort();
            insertion.Execute(unsortedList);
            var selection = new SelectionSort();
		    selection.Execute(unsortedList);
	    }
    }
}

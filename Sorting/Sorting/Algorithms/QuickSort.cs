namespace Sorting.Algorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class QuickSort// : SortBase
    {
        //public override IEnumerable<int> Execute(IEnumerable<int> unsortedList)
        //{
        //    var copy = Copy(unsortedList).ToArray();

        //    //Quicksort(copy, 0, copy.Length - 1);

        //    return copy;
        //}

        /*
        algorithm quicksort(A, lo, hi) is
            if lo < hi then
                p := partition(A, lo, hi)
                quicksort(A, lo, p - 1 )
                quicksort(A, p + 1, hi)         
        */
        private void Quicksort(int[] A, int lo, int hi)
        {
            if (lo < hi)
            {
                var pivot = Partition(A, lo, hi);
                Quicksort(A, lo, pivot - 1);
                Quicksort(A, pivot + 1, hi);
            }
        }

        /*
        algorithm partition(A, lo, hi) is
            pivot := A[hi]
            i := lo - 1  
            for j := lo to hi - 1 do
                if A[j] < pivot then
                    if i != j then
                        i := i + 1
                        swap A[i] with A[j]
           
            i := i + 1
            swap A[i] with A[hi]
            return i
         */
        private int Partition(int[] A, int lo, int hi)
        {
            var pivot = A[hi];
            var i = lo - 1;
            for (int j = lo; j < hi - 1;)
            {
                if (A[j] < pivot)
                {
                    if (i != j)
                    {
                        i = i + 1;
                        var temp = A[j];
                        A[j] = A[i];
                        A[i] = temp;
                    }
                }

                i = i + 1;
                if (i >= A.Length)
                {
                    break;
                }

                var temp2 = A[j];
                A[j] = A[i];
                A[i] = temp2;
            }

            return i;
        }
    }
}

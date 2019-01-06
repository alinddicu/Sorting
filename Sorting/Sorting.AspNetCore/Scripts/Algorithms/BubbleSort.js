/// <reference path="./SortBase.ts"/>
var Algorithms;
(function (Algorithms) {
    class BubbleSort extends Algorithms.BaseSort {
        execute(unsortedList) {
            //base.Execute(unsortedList);
            let sortedList = super.copy(unsortedList);
            //AddToIntermediateSorts(sortedList);
            let inversion;
            do {
                inversion = false;
                for (let i = 0; i < sortedList.length - 1; i++) {
                    let left = sortedList[i];
                    let right = sortedList[i + 1];
                    if (left > right) {
                        sortedList[i] = right;
                        sortedList[i + 1] = left;
                        inversion = true;
                    }
                }
            } while (inversion);
            //StopWatch();
            return sortedList;
        }
    }
    Algorithms.BubbleSort = BubbleSort;
})(Algorithms || (Algorithms = {}));
//# sourceMappingURL=BubbleSort.js.map
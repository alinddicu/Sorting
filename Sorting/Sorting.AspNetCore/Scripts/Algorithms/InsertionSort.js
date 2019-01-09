/// <reference path="./SortBase.ts"/>
var Algorithms;
(function (Algorithms) {
    class InsertionSort extends Algorithms.SortBase {
        execute(unsortedList) {
            super.execute(unsortedList);
            super.addToIntermediateSorts(unsortedList);
            let sortedList = [];
            for (let j = 0; j < unsortedList.length; j++) {
                const unsortedItem = unsortedList[j];
                let inserted = false;
                for (let i = sortedList.length - 1; !inserted && i >= 0; i--) {
                    const sortedItem = sortedList[i];
                    let sortedItemMinus1 = null;
                    if (i !== 0 && sortedList.length >= 2) {
                        sortedItemMinus1 = sortedList[i - 1];
                    }
                    if (unsortedItem < sortedItem && (sortedItemMinus1 === null || unsortedItem > sortedItemMinus1)) {
                        sortedList.splice(i, 0, unsortedItem);
                        super.addToIntermediateSorts(sortedList);
                        inserted = true;
                    }
                }
                if (!inserted) {
                    sortedList.push(unsortedItem);
                    super.addToIntermediateSorts(sortedList);
                }
            }
            //StopWatch();
            return sortedList;
        }
    }
    Algorithms.InsertionSort = InsertionSort;
})(Algorithms || (Algorithms = {}));
//# sourceMappingURL=InsertionSort.js.map
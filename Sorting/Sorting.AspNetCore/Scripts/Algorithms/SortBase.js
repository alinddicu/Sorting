var Algorithms;
(function (Algorithms) {
    class BaseSort {
        copy(list) {
            let newArray = [];
            for (let i = 0; i < list.length; i++) {
                newArray[i] = list[i];
            }
            return newArray;
        }
        addToIntermediateSorts(intermediateSort) {
            this.intermediateSorts.push(intermediateSort);
        }
        execute(unsortedList) {
            this.intermediateSorts = [];
            return unsortedList;
        }
    }
    Algorithms.BaseSort = BaseSort;
})(Algorithms || (Algorithms = {}));
//# sourceMappingURL=SortBase.js.map
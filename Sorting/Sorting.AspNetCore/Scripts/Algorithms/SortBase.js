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
    }
    Algorithms.BaseSort = BaseSort;
})(Algorithms || (Algorithms = {}));
//# sourceMappingURL=SortBase.js.map
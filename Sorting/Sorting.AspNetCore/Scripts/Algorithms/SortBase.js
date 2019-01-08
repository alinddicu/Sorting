var Algorithms;
(function (Algorithms) {
    class SortBase {
        copy(list) {
            let newArray = [];
            for (let i = 0; i < list.length; i++) {
                newArray[i] = list[i];
            }
            return newArray;
        }
        addToIntermediateSorts(intermediateSort) {
            this.intermediateSorts.push(this.copy(intermediateSort));
        }
        execute(unsortedList) {
            this.intermediateSorts = [];
            return unsortedList;
        }
        getIntermediateSorts() {
            return this.intermediateSorts;
        }
    }
    Algorithms.SortBase = SortBase;
})(Algorithms || (Algorithms = {}));
//# sourceMappingURL=SortBase.js.map
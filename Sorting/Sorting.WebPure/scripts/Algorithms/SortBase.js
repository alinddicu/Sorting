var Algorithms;
(function (Algorithms) {
    var SortBase = /** @class */ (function () {
        function SortBase() {
        }
        SortBase.prototype.copy = function (list) {
            var newArray = [];
            for (var i = 0; i < list.length; i++) {
                newArray[i] = list[i];
            }
            return newArray;
        };
        SortBase.prototype.addToIntermediateSorts = function (intermediateSort) {
            this.intermediateSorts.push(this.copy(intermediateSort));
        };
        SortBase.prototype.execute = function (unsortedList) {
            this.intermediateSorts = [];
            return unsortedList;
        };
        SortBase.prototype.getIntermediateSorts = function () {
            return this.intermediateSorts;
        };
        return SortBase;
    }());
    Algorithms.SortBase = SortBase;
})(Algorithms || (Algorithms = {}));
//# sourceMappingURL=SortBase.js.map
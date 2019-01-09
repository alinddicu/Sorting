/// <reference path="./SortBase.ts"/>
var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Algorithms;
(function (Algorithms) {
    var InsertionSort = /** @class */ (function (_super) {
        __extends(InsertionSort, _super);
        function InsertionSort() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        InsertionSort.prototype.execute = function (unsortedList) {
            _super.prototype.execute.call(this, unsortedList);
            _super.prototype.addToIntermediateSorts.call(this, unsortedList);
            var sortedList = [];
            for (var j = 0; j < unsortedList.length; j++) {
                var unsortedItem = unsortedList[j];
                var inserted = false;
                for (var i = sortedList.length - 1; !inserted && i >= 0; i--) {
                    var sortedItem = sortedList[i];
                    var sortedItemMinus1 = null;
                    if (i !== 0 && sortedList.length >= 2) {
                        sortedItemMinus1 = sortedList[i - 1];
                    }
                    if (unsortedItem < sortedItem && (sortedItemMinus1 === null || unsortedItem > sortedItemMinus1)) {
                        sortedList.splice(i, 0, unsortedItem);
                        _super.prototype.addToIntermediateSorts.call(this, sortedList);
                        inserted = true;
                    }
                }
                if (!inserted) {
                    sortedList.push(unsortedItem);
                    _super.prototype.addToIntermediateSorts.call(this, sortedList);
                }
            }
            //StopWatch();
            return sortedList;
        };
        return InsertionSort;
    }(Algorithms.SortBase));
    Algorithms.InsertionSort = InsertionSort;
})(Algorithms || (Algorithms = {}));
//# sourceMappingURL=InsertionSort.js.map
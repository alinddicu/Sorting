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
    var BubbleSort = /** @class */ (function (_super) {
        __extends(BubbleSort, _super);
        function BubbleSort() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        BubbleSort.prototype.execute = function (unsortedList) {
            _super.prototype.execute.call(this, unsortedList);
            var sortedList = _super.prototype.copy.call(this, unsortedList);
            _super.prototype.addToIntermediateSorts.call(this, sortedList);
            var inversion;
            do {
                inversion = false;
                for (var i = 0; i < sortedList.length - 1; i++) {
                    var left = sortedList[i];
                    var right = sortedList[i + 1];
                    if (left > right) {
                        sortedList[i] = right;
                        sortedList[i + 1] = left;
                        inversion = true;
                        _super.prototype.addToIntermediateSorts.call(this, sortedList);
                    }
                }
            } while (inversion);
            //StopWatch();
            return sortedList;
        };
        return BubbleSort;
    }(Algorithms.SortBase));
    Algorithms.BubbleSort = BubbleSort;
})(Algorithms || (Algorithms = {}));
//# sourceMappingURL=BubbleSort.js.map
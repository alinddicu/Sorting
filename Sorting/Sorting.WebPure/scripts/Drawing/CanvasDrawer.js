/// <reference path="../Algorithms/SortBase.ts"/>
/// <reference path="../Algorithms/BubbleSort.ts"/>
var Drawing;
(function (Drawing) {
    var CanvasDrawer = /** @class */ (function () {
        function CanvasDrawer(sorting) {
            this.sorting = sorting;
        }
        CanvasDrawer.prototype.Draw = function (canvas) {
            var intermediateSorts = this.sorting.getIntermediateSorts();
            var ctx = canvas.getContext("2d");
            ctx.strokeStyle = "#FF0000";
            var i = 0;
            var refreshId = setInterval(function () {
                ctx.clearRect(0, 0, canvas.width, canvas.height);
                ctx.beginPath();
                var intermediateSort = intermediateSorts[i++];
                //console.log("intermediateSort: " + intermediateSort);
                for (var x = 0; x < intermediateSort.length; x++) {
                    var y = intermediateSort[x];
                    ctx.moveTo(1 + x * 10, canvas.height);
                    //console.log(`ctx.moveTo(${x}, 0)`);
                    ctx.lineTo(1 + x * 10, canvas.height - y * 10);
                    //console.log(`ctx.lineTo(${x}, ${y})`);
                    ctx.stroke();
                }
                if (i >= intermediateSorts.length) {
                    clearInterval(refreshId);
                }
            }, 200);
        };
        return CanvasDrawer;
    }());
    Drawing.CanvasDrawer = CanvasDrawer;
})(Drawing || (Drawing = {}));
//# sourceMappingURL=CanvasDrawer.js.map
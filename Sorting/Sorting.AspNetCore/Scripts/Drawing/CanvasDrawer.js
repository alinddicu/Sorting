/// <reference path="../Algorithms/SortBase.ts"/>
/// <reference path="../Algorithms/BubbleSort.ts"/>
var Drawing;
(function (Drawing) {
    class CanvasDrawer {
        constructor(sorting) {
            this.sorting = sorting;
        }
        Draw(canvas) {
            const intermediateSorts = this.sorting.getIntermediateSorts();
            var ctx = canvas.getContext("2d");
            ctx.strokeStyle = "#FF0000";
            let i = 0;
            let refreshId = setInterval(() => {
                ctx.clearRect(0, 0, canvas.width, canvas.height);
                ctx.beginPath();
                let intermediateSort = intermediateSorts[i++];
                //console.log("intermediateSort: " + intermediateSort);
                for (let x = 0; x < intermediateSort.length; x++) {
                    const y = intermediateSort[x];
                    ctx.moveTo(1 + x * 10, canvas.height);
                    //console.log(`ctx.moveTo(${x}, 0)`);
                    ctx.lineTo(1 + x * 10, canvas.height - y * 10);
                    //console.log(`ctx.lineTo(${x}, ${y})`);
                    ctx.stroke();
                }
                if (i >= intermediateSorts.length) {
                    clearInterval(refreshId);
                }
            }, 0);
        }
    }
    Drawing.CanvasDrawer = CanvasDrawer;
})(Drawing || (Drawing = {}));
//# sourceMappingURL=CanvasDrawer.js.map
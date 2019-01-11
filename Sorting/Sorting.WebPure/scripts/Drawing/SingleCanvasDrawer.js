var Drawing;
(function (Drawing) {
    class SingleCanvasDrawer {
        constructor(sorting, document) {
            this.sorting = sorting;
            this.document = document;
        }
        Draw(xDrawRation) {
            const divId = this.sorting.constructor.name.toLowerCase();
            const intermediateSorts = this.sorting.getIntermediateSorts();
            const sortedNumbersCount = intermediateSorts[0].length;
            const div = document.getElementById(divId);
            const canvas = document.createElement("canvas");
            canvas.id = divId;
            canvas.height = sortedNumbersCount * xDrawRation;
            canvas.width = sortedNumbersCount * xDrawRation;
            div.appendChild(canvas);
            //const canvas = document.getElementById(divId) as HTMLCanvasElement;
            const ctx = canvas.getContext("2d");
            ctx.strokeStyle = "#FF0000";
            let i = 0;
            let refreshId = setInterval(() => {
                ctx.clearRect(0, 0, canvas.width, canvas.height);
                ctx.beginPath();
                let intermediateSort = intermediateSorts[i++];
                //console.log("intermediateSort: " + intermediateSort);
                for (let x = 0; x < intermediateSort.length; x++) {
                    const y = intermediateSort[x];
                    ctx.moveTo(1 + x * xDrawRation, canvas.height);
                    //console.log(`ctx.moveTo(${x}, 0)`);
                    ctx.lineTo(1 + x * xDrawRation, canvas.height - y * xDrawRation);
                    //console.log(`ctx.lineTo(${x}, ${y})`);
                    ctx.stroke();
                }
                if (i >= intermediateSorts.length) {
                    clearInterval(refreshId);
                }
            }, 200);
        }
    }
    Drawing.SingleCanvasDrawer = SingleCanvasDrawer;
})(Drawing || (Drawing = {}));
//# sourceMappingURL=SingleCanvasDrawer.js.map
var Drawing;
(function (Drawing) {
    class MultiCanvasDrawer {
        constructor(document, sortings, xDrawRation) {
            this.document = document;
            this.sortings = sortings;
            this.xDrawRatio = xDrawRation;
        }
        Draw(arrayToSort) {
            for (let sorting of this.sortings) {
                sorting.execute(arrayToSort);
                new Drawing.SingleCanvasDrawer(sorting, this.document).Draw(this.xDrawRatio);
            }
        }
    }
    Drawing.MultiCanvasDrawer = MultiCanvasDrawer;
})(Drawing || (Drawing = {}));
//# sourceMappingURL=MultiCanvasDrawer.js.map
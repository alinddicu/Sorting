namespace Drawing {
	import SortBase = Algorithms.SortBase;

	export class MultiCanvasDrawer {
		document: Document;
		sortings: SortBase[];
		xDrawRatio: number;
		drawDelay: number;

		constructor(document: Document, sortings: SortBase[], xDrawRation: number, drawDelay: number) {
			this.document = document;
			this.sortings = sortings;
			this.xDrawRatio = xDrawRation;
			this.drawDelay = drawDelay;
		}

		public draw(arrayToSort: number[]): void {
			for (let sorting of this.sortings) {
				sorting.execute(arrayToSort);
				new SingleCanvasDrawer(sorting, this.document).draw(this.xDrawRatio, this.drawDelay);
			}
		}
	}
}
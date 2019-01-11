namespace Drawing {
	import SortBase = Algorithms.SortBase;

	export class MultiCanvasDrawer {
		document: Document;
		sortings: SortBase[];
		drawParams: IDrawingParams;

		constructor(document: Document, sortings: SortBase[], drawParams: IDrawingParams) {
			this.document = document;
			this.sortings = sortings;
			this.drawParams = drawParams;
		}

		public draw(arrayToSort: number[]): void {
			for (let sorting of this.sortings) {
				sorting.execute(arrayToSort);
				new SingleCanvasDrawer(sorting, this.document).draw(this.drawParams);
			}
		}
	}
}
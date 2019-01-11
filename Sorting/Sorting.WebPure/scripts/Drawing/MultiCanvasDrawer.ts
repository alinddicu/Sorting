namespace Drawing {
	import SortBase = Algorithms.SortBase;

	export class MultiCanvasDrawer {
		document: Document;
		sortings: SortBase[];
		xDrawRatio: number;

		constructor(document: Document, sortings: SortBase[], xDrawRation: number) {
			this.document = document;
			this.sortings = sortings;
			this.xDrawRatio = xDrawRation;
		}

		public Draw(arrayToSort: number[]): void {
			for (let sorting of this.sortings) {
				sorting.execute(arrayToSort);
				new SingleCanvasDrawer(sorting, this.document).Draw(this.xDrawRatio);
			}
		}
	}
}
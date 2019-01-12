namespace Drawing {
	import SortBase = Algorithms.SortBase;

	export class MultiCanvasDrawer {
		private document: Document;
		private sortings: SortBase[];
		private drawParams: IDrawingParams;

		constructor(document: Document, drawParams: IDrawingParams) {
			this.document = document;
			this.sortings = [
				new Algorithms.BubbleSort(),
				new Algorithms.InsertionSort(),
				new Algorithms.HeapSort(),
				new Algorithms.MergeSort(),
				new Algorithms.QuickSort(),
				new Algorithms.SelectionSort()
			];
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
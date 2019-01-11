namespace Drawing {
	import SortBase = Algorithms.SortBase;

	export class SingleCanvasDrawer {
		sorting: SortBase;
		document: Document;

		constructor(sorting: SortBase, document: Document) {
			this.sorting = sorting;
			this.document = document;
		}

		private createCanvas(xDrawRation: number, sortedNumbersCount: number): HTMLCanvasElement {
			const divId = this.sorting.constructor.name.toLowerCase();
			const div = document.getElementById(divId) as HTMLDivElement;
			const canvas = document.createElement("canvas") as HTMLCanvasElement;
			canvas.id = divId;
			canvas.height = sortedNumbersCount * xDrawRation;
			canvas.width = sortedNumbersCount * xDrawRation;
			div.appendChild<HTMLCanvasElement>(canvas);

			return canvas;
		}

		public draw(xDrawRatio: number, drawDelay: number): void {

			const intermediateSorts = this.sorting.getIntermediateSorts();
			const sortedNumbersCount = intermediateSorts[0].length;
			const canvas = this.createCanvas(xDrawRatio, sortedNumbersCount);
			const ctx = canvas.getContext("2d") as CanvasRenderingContext2D;
			ctx.strokeStyle = "#FF0000";

			let i = 0;
			const refreshId = setInterval(() => {
				ctx.clearRect(0, 0, canvas.width, canvas.height);
				ctx.beginPath();
				const intermediateSort = intermediateSorts[i++];
				for (let x = 0; x < intermediateSort.length; x++) {
					const y = intermediateSort[x];
					ctx.moveTo(1 + x * xDrawRatio, canvas.height);
					ctx.lineTo(1 + x * xDrawRatio, canvas.height - y * xDrawRatio);
					ctx.stroke();
				}

				if (i >= intermediateSorts.length) {
					clearInterval(refreshId);
				}
			}, drawDelay);
		}
	}
}
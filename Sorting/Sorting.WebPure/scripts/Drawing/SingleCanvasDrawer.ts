namespace Drawing {
	import SortBase = Algorithms.SortBase;

	export class SingleCanvasDrawer {
		private sorting: SortBase;
		private document: Document;
		private drawParams: IDrawingParams;

		constructor(sorting: SortBase, document: Document) {
			this.sorting = sorting;
			this.document = document;
		}

		private createCanvas(sortedNumbersCount: number): HTMLCanvasElement {
			const ratio = this.drawParams.ratio;
			const divId = this.sorting.constructor.name.toLowerCase();
			const div = document.getElementById(divId) as HTMLDivElement;
			const canvas = document.createElement("canvas") as HTMLCanvasElement;
			canvas.id = divId;
			canvas.height = sortedNumbersCount * ratio;
			canvas.width = sortedNumbersCount * ratio;
			canvas.style.backgroundColor = this.drawParams.backgroundColor;
			div.appendChild<HTMLCanvasElement>(canvas);

			return canvas;
		}

		private drawCanvasBorder(canvas: HTMLCanvasElement): void {
			const context = canvas.getContext("2d") as CanvasRenderingContext2D;
			context.globalCompositeOperation = "source-over";
			context.lineWidth = 2;
			context.strokeStyle = this.drawParams.penColor;
			context.strokeRect(0, 0, canvas.width, canvas.height);
		}

		public draw(drawParams: IDrawingParams): void {

			this.drawParams = drawParams;
			const ratio = this.drawParams.ratio;
			const intermediateSorts = this.sorting.getIntermediateSorts();
			const sortedNumbersCount = intermediateSorts[0].length;
			const canvas = this.createCanvas(sortedNumbersCount);
			const ctx = canvas.getContext("2d") as CanvasRenderingContext2D;
			ctx.strokeStyle = this.drawParams.penColor;

			let i = 0;
			const refreshId = setInterval(() => {
				ctx.clearRect(0, 0, canvas.width, canvas.height);
				ctx.beginPath();
				const intermediateSort = intermediateSorts[i++];
				for (let x = 0; x < intermediateSort.length; x++) {
					const y = intermediateSort[x];
					ctx.moveTo(5 + x * ratio, canvas.height);
					ctx.lineTo(5 + x * ratio, canvas.height - y * ratio);
					ctx.stroke();
				}

				if (i === intermediateSorts.length) {
					clearInterval(refreshId);
				}
			}, drawParams.delay);
		}
	}
}
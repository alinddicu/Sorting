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

		private getDivId(): string {
			return this.sorting.constructor.name.toLowerCase();
		}

		private createCanvas(sortedNumbersCount: number): HTMLCanvasElement {
			const ratio = this.drawParams.step;
			const divId = this.getDivId();
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

		private writeSortingText(canvasCtx: CanvasRenderingContext2D): void {
			canvasCtx.font = `${this.drawParams.fontSize}px Times New Roman`;
			const sorting = this.getDivId().split("sort")[0];
			const sortingFormatted = sorting[0].toUpperCase() + sorting.substr(1).toLowerCase();
			const duration = this.sorting.getDuration();
			const text = `${sortingFormatted} Sort (${duration}ms)`;
			canvasCtx.strokeText(text, 10, 20);
		}

		public draw(drawParams: IDrawingParams): void {
			this.drawParams = drawParams;
			const step = this.drawParams.step;
			const intermediateSorts = this.sorting.getIntermediateSorts();
			const sortedNumbersCount = intermediateSorts[0].length;
			const canvas = this.createCanvas(sortedNumbersCount);
			const canvasCtx = canvas.getContext("2d") as CanvasRenderingContext2D;
			canvasCtx.strokeStyle = this.drawParams.penColor;

			let i = 0;
			const refreshId = setInterval(() => {
				canvasCtx.clearRect(0, 0, canvas.width, canvas.height);
				canvasCtx.beginPath();
				const intermediateSort = intermediateSorts[i++];
				for (let x = 0; x < intermediateSort.length; x++) {
					const y = intermediateSort[x];
					canvasCtx.moveTo(5 + x * step, canvas.height);
					canvasCtx.lineTo(5 + x * step, canvas.height - y * step);
					canvasCtx.stroke();
				}

				this.writeSortingText(canvasCtx);
				if (i === intermediateSorts.length) {
					clearInterval(refreshId);
				}
			}, drawParams.delay);
		}
	}
}
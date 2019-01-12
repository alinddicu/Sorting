namespace Algorithms {
	export class SortBase {
		private intermediateSorts: number[][];
		private start: number;
		private end: number;

		protected copy(array: number[]): number[] {
			const newArray: number[] = [];
			for (let i = 0; i < array.length; i++) {
				newArray[i] = array[i];
			}

			return newArray;
		}

		protected addToIntermediateSorts(intermediateSort: number[]) {
			this.intermediateSorts.push(this.copy(intermediateSort));
		}

		public execute(unsortedList: number[]): number[] {
			this.start = new Date().getTime();
			this.intermediateSorts = [];
			return unsortedList;
		}

		public getIntermediateSorts(): number[][] {
			return this.intermediateSorts;
		}

		protected stopWatch(): void {
			this.end = new Date().getTime();
		}

		public getDuration(): number {
			return this.end - this.start;
		}
	}
}
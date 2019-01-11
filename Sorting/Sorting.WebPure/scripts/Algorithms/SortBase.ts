namespace Algorithms {
	export class SortBase {
		private intermediateSorts: number[][];

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
			this.intermediateSorts = [];
			return unsortedList;
		}

		public getIntermediateSorts(): number[][] {
			return this.intermediateSorts;
		}
	}
}
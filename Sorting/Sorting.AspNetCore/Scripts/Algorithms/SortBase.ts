namespace Algorithms {
	export class BaseSort {
		intermediateSorts: number[][];
		public copy(list: number[]): number[] {
			let newArray: number[] = [];
			for (let i = 0; i < list.length; i++) {
				newArray[i] = list[i];
			}

			return newArray;
		}

		protected addToIntermediateSorts(intermediateSort: number[]) {
			this.intermediateSorts.push(intermediateSort);
		}

		public execute(unsortedList: number[]): number[] {
			this.intermediateSorts = [];
			return unsortedList;
		}
	}
}
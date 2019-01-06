namespace Algorithms {
	export class BaseSort {
		public copy(list: number[]): number[] {
			let newArray: number[] = [];
			for (let i = 0; i < list.length; i++) {
				newArray[i] = list[i];
			}

			return newArray;
		}
	}
}
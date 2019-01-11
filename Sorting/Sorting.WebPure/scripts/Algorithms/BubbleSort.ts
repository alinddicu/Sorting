namespace Algorithms {
	export class BubbleSort extends SortBase {
		public execute(unsortedList: number[]): number[] {
			super.execute(unsortedList);
			let sortedList = super.copy(unsortedList);
			super.addToIntermediateSorts(sortedList);

			let inversion: boolean;
			do {
				inversion = false;
				for(let i = 0; i < sortedList.length - 1; i++) {
					let left: number = sortedList[i];
					let right: number = sortedList[i + 1];
					if (left > right) {
						sortedList[i] = right;
						sortedList[i + 1] = left;
						inversion = true;
						super.addToIntermediateSorts(sortedList);
					}
				}
			} while (inversion);

			// stopWatch();
			return sortedList;
		}
	}
}
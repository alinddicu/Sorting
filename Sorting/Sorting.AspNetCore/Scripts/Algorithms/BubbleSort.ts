/// <reference path="./SortBase.ts"/>

namespace Algorithms {
	export class BubbleSort extends BaseSort {
		public execute(unsortedList: number[]): number[] {
			//base.Execute(unsortedList);
			let sortedList = super.copy(unsortedList);
			//AddToIntermediateSorts(sortedList);

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
						//AddToIntermediateSorts(sortedList);
					}
				}
			} while (inversion);

			//StopWatch();
			return sortedList;
		}
	}
}
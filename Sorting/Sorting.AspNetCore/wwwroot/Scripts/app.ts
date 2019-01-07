/// <reference path="./Algorithms/BubbleSort.ts"/>

function testSort(): any {
	const sort = new Algorithms.BubbleSort();
	const result = sort.execute([3, 2, 1]);
	return {
		result: result,
		intermediateSorts: JSON.stringify(sort.getIntermediateSorts())
	};
}
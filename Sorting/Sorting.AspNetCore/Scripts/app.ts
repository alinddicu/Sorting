/// <reference path="./Algorithms/BubbleSort.ts"/>

function testSort(): number[] {
	const sort = new Algorithms.BubbleSort();
	const result = sort.execute([3, 2, 1]);
	return result; //.trim("]").trim("[");
}
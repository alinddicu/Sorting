/// <reference path="./Algorithms/BubbleSort.ts"/>
/// <reference path="./Drawing/CanvasDrawer.ts"/>

const sort = new Algorithms.BubbleSort();
//const arrayToSort = [81, 76, 9, 27, 58, 66, 83, 43, 63, 19, 47, 26, 59, 17, 94, 65, 14, 20, 74, 69, 7, 34, 72, 23, 99, 48, 96, 62, 1, 55, 92, 91, 32, 71, 54, 44, 60, 73, 37, 97, 11, 95, 46, 56, 42, 80, 5, 21, 30, 39, 98, 61, 87, 41, 90, 29, 84, 6, 64, 51, 75, 8, 12, 67, 31, 88, 57, 16, 68, 86, 10, 24, 77, 93, 100, 53, 82, 3, 49, 78, 22, 18, 45, 89, 52, 2, 25, 85, 79, 28, 38, 40, 13, 15, 70, 35, 4, 50, 36, 33];
const arrayToSort = [9, 8, 7, 6, 5, 4, 3, 2, 1, 0];
const result = sort.execute(arrayToSort);
	
function executeSort(): any {return {
		result: result,
		intermediateSorts: JSON.stringify(sort.getIntermediateSorts())
	};
}

function drawSort(canvas: any): void {
	const canvasDrawer = new Drawing.CanvasDrawer(sort);
	canvasDrawer.Draw(canvas);
}
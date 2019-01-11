﻿/// <reference path="Drawing/MultiCanvasDrawer.ts"/>>

const arrayToSort = [10, 9, 8, 7, 6, 5, 4, 3, 2, 1];
//const arrayToSort = [11,2,18,4,7,1,9,19,6,14,5,8,17,13,15,16,3,12,20,10];
//const arrayToSort = [28,4,12,9,25,5,7,15,30,23,2,10,14,13,6,21,18,1,19,17,24,29,11,27,8,16,22,20,26,3];
//const arrayToSort = [12,10,20,4,23,19,14,25,33,38,2,16,5,11,27,32,30,22,28,3,7,39,37,18,26,31,24,21,40,29,35,1,36,34,15,9,6,13,8,17];
//const arrayToSort = [14,35,5,38,28,49,6,39,30,4,18,13,8,31,3,22,9,32,37,20,11,15,36,40,46,50,16,2,33,47,29,26,21,44,19,48,12,10,24,45,34,27,7,43,23,42,1,41,25,17];
//const arrayToSort = [81, 76, 9, 27, 58, 66, 83, 43, 63, 19, 47, 26, 59, 17, 94, 65, 14, 20, 74, 69, 7, 34, 72, 23, 99, 48, 96, 62, 1, 55, 92, 91, 32, 71, 54, 44, 60, 73, 37, 97, 11, 95, 46, 56, 42, 80, 5, 21, 30, 39, 98, 61, 87, 41, 90, 29, 84, 6, 64, 51, 75, 8, 12, 67, 31, 88, 57, 16, 68, 86, 10, 24, 77, 93, 100, 53, 82, 3, 49, 78, 22, 18, 45, 89, 52, 2, 25, 85, 79, 28, 38, 40, 13, 15, 70, 35, 4, 50, 36, 33];

//const bubbleSort = new Algorithms.BubbleSort();
//bubbleSort.execute(arrayToSort);

//const insertionSort = new Algorithms.InsertionSort();
//const result = insertionSort.execute(arrayToSort);
	
//function executeSort(): any {return {
//		result: result,
//		intermediateSorts: JSON.stringify(insertionSort.getIntermediateSorts())
//	};
//}

//function drawSort(sort: Algorithms.SortBase): void {
//	const canvasDrawer = new Drawing.SingleCanvasDrawer(sort, document);
//	canvasDrawer.Draw();
//}
function draw() {
	const sortings: Algorithms.SortBase[] = [
		new Algorithms.BubbleSort(),
		new Algorithms.InsertionSort()
	];
	new Drawing.MultiCanvasDrawer(document, sortings, 10).Draw(arrayToSort);	
}

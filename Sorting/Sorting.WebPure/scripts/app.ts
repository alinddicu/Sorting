function draw() {
	const drawParams = {
		step: (document.getElementById("step") as HTMLFormElement).valueAsNumber as number,
		delay: (document.getElementById("delay") as HTMLFormElement).valueAsNumber as number,
		penColor: (document.getElementById("penColor") as HTMLFormElement).value as string,
		backgroundColor: (document.getElementById("backgroundColor") as HTMLFormElement).value as string,
		fontSize: (document.getElementById("fontSize") as HTMLFormElement).valueAsNumber as number
	};
	const arraySize = (document.getElementById("arraySize") as HTMLFormElement).valueAsNumber as number;
	const startValue = (document.getElementById("startValue") as HTMLFormElement).valueAsNumber as number;
	const arrayToSort = new Tools.RandomArrayGenerator().Generate(arraySize, startValue);
	new Drawing.MultiCanvasDrawer(document, drawParams).draw(arrayToSort);
}

const drawParams = {
	ratio: 10,
	delay: 50,
	penColor: "lime",
	backgroundColor: "black"
};

function draw() {
	const arrayToSort = new Tools.RandomArrayGenerator().Generate(34, 1);
	new Drawing.MultiCanvasDrawer(document, drawParams).draw(arrayToSort);
}

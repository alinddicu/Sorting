function sort() {
	function valueOrDefault<T>(elementId: string, defaultValue: any): T {
		const inputField = document.getElementById(elementId) as HTMLFormElement;
		let value;
		if (typeof defaultValue === "number") {
			value = inputField.valueAsNumber;
		}
		else if (typeof defaultValue === "string") {
			value = inputField.valueAsString;
		} else {
			value = inputField.valueAsDate;
		}

		return value ? value : defaultValue;
	}

	const drawParams = {
		step: valueOrDefault<number>("step", 10),
		delay: valueOrDefault<number>("delay", 50),
		penColor: valueOrDefault<string>("penColor", "lime"),
		backgroundColor: valueOrDefault<string>("backgroundColor", "black"),
		fontSize: valueOrDefault<number>("fontSize", 16)
	};

	const arraySize = valueOrDefault<number>("arraySize", 34);
	const startValue = valueOrDefault<number>("startValue", 1);
	const arrayToSort = new Tools.RandomArrayGenerator().Generate(arraySize, startValue);
	new Drawing.MultiCanvasDrawer(document, drawParams).draw(arrayToSort);
}

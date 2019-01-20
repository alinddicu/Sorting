var Algorithms;
(function (Algorithms) {
    class BubbleSort extends Algorithms.SortBase {
        execute(unsortedList) {
            super.execute(unsortedList);
            const sortedList = super.copy(unsortedList);
            super.addToIntermediateSorts(sortedList);
            let inversion;
            do {
                inversion = false;
                for (let i = 0; i < sortedList.length - 1; i++) {
                    const left = sortedList[i];
                    const right = sortedList[i + 1];
                    if (left > right) {
                        sortedList[i] = right;
                        sortedList[i + 1] = left;
                        inversion = true;
                        super.addToIntermediateSorts(sortedList);
                    }
                }
            } while (inversion);
            this.stopWatch();
            return sortedList;
        }
    }
    Algorithms.BubbleSort = BubbleSort;
})(Algorithms || (Algorithms = {}));
//# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiQnViYmxlU29ydC5qcyIsInNvdXJjZVJvb3QiOiIiLCJzb3VyY2VzIjpbIkJ1YmJsZVNvcnQudHMiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUEsSUFBVSxVQUFVLENBMEJuQjtBQTFCRCxXQUFVLFVBQVU7SUFDbkIsZ0JBQXdCLFNBQVEsV0FBQSxRQUFRO1FBQ2hDLE9BQU8sQ0FBQyxZQUFzQjtZQUNwQyxLQUFLLENBQUMsT0FBTyxDQUFDLFlBQVksQ0FBQyxDQUFDO1lBQzVCLE1BQU0sVUFBVSxHQUFHLEtBQUssQ0FBQyxJQUFJLENBQUMsWUFBWSxDQUFDLENBQUM7WUFDNUMsS0FBSyxDQUFDLHNCQUFzQixDQUFDLFVBQVUsQ0FBQyxDQUFDO1lBRXpDLElBQUksU0FBa0IsQ0FBQztZQUN2QixHQUFHLENBQUM7Z0JBQ0gsU0FBUyxHQUFHLEtBQUssQ0FBQztnQkFDbEIsR0FBRyxDQUFBLENBQUMsSUFBSSxDQUFDLEdBQUcsQ0FBQyxFQUFFLENBQUMsR0FBRyxVQUFVLENBQUMsTUFBTSxHQUFHLENBQUMsRUFBRSxDQUFDLEVBQUUsRUFBRSxDQUFDO29CQUMvQyxNQUFNLElBQUksR0FBVyxVQUFVLENBQUMsQ0FBQyxDQUFDLENBQUM7b0JBQ25DLE1BQU0sS0FBSyxHQUFXLFVBQVUsQ0FBQyxDQUFDLEdBQUcsQ0FBQyxDQUFDLENBQUM7b0JBQ3hDLEVBQUUsQ0FBQyxDQUFDLElBQUksR0FBRyxLQUFLLENBQUMsQ0FBQyxDQUFDO3dCQUNsQixVQUFVLENBQUMsQ0FBQyxDQUFDLEdBQUcsS0FBSyxDQUFDO3dCQUN0QixVQUFVLENBQUMsQ0FBQyxHQUFHLENBQUMsQ0FBQyxHQUFHLElBQUksQ0FBQzt3QkFDekIsU0FBUyxHQUFHLElBQUksQ0FBQzt3QkFDakIsS0FBSyxDQUFDLHNCQUFzQixDQUFDLFVBQVUsQ0FBQyxDQUFDO29CQUMxQyxDQUFDO2dCQUNGLENBQUM7WUFDRixDQUFDLFFBQVEsU0FBUyxFQUFFO1lBRXBCLElBQUksQ0FBQyxTQUFTLEVBQUUsQ0FBQztZQUNqQixNQUFNLENBQUMsVUFBVSxDQUFDO1FBQ25CLENBQUM7S0FDRDtJQXhCWSxxQkFBVSxhQXdCdEIsQ0FBQTtBQUNGLENBQUMsRUExQlMsVUFBVSxLQUFWLFVBQVUsUUEwQm5CIiwic291cmNlc0NvbnRlbnQiOlsibmFtZXNwYWNlIEFsZ29yaXRobXMge1xyXG5cdGV4cG9ydCBjbGFzcyBCdWJibGVTb3J0IGV4dGVuZHMgU29ydEJhc2Uge1xyXG5cdFx0cHVibGljIGV4ZWN1dGUodW5zb3J0ZWRMaXN0OiBudW1iZXJbXSk6IG51bWJlcltdIHtcclxuXHRcdFx0c3VwZXIuZXhlY3V0ZSh1bnNvcnRlZExpc3QpO1xyXG5cdFx0XHRjb25zdCBzb3J0ZWRMaXN0ID0gc3VwZXIuY29weSh1bnNvcnRlZExpc3QpO1xyXG5cdFx0XHRzdXBlci5hZGRUb0ludGVybWVkaWF0ZVNvcnRzKHNvcnRlZExpc3QpO1xyXG5cclxuXHRcdFx0bGV0IGludmVyc2lvbjogYm9vbGVhbjtcclxuXHRcdFx0ZG8ge1xyXG5cdFx0XHRcdGludmVyc2lvbiA9IGZhbHNlO1xyXG5cdFx0XHRcdGZvcihsZXQgaSA9IDA7IGkgPCBzb3J0ZWRMaXN0Lmxlbmd0aCAtIDE7IGkrKykge1xyXG5cdFx0XHRcdFx0Y29uc3QgbGVmdDogbnVtYmVyID0gc29ydGVkTGlzdFtpXTtcclxuXHRcdFx0XHRcdGNvbnN0IHJpZ2h0OiBudW1iZXIgPSBzb3J0ZWRMaXN0W2kgKyAxXTtcclxuXHRcdFx0XHRcdGlmIChsZWZ0ID4gcmlnaHQpIHtcclxuXHRcdFx0XHRcdFx0c29ydGVkTGlzdFtpXSA9IHJpZ2h0O1xyXG5cdFx0XHRcdFx0XHRzb3J0ZWRMaXN0W2kgKyAxXSA9IGxlZnQ7XHJcblx0XHRcdFx0XHRcdGludmVyc2lvbiA9IHRydWU7XHJcblx0XHRcdFx0XHRcdHN1cGVyLmFkZFRvSW50ZXJtZWRpYXRlU29ydHMoc29ydGVkTGlzdCk7XHJcblx0XHRcdFx0XHR9XHJcblx0XHRcdFx0fVxyXG5cdFx0XHR9IHdoaWxlIChpbnZlcnNpb24pO1xyXG5cclxuXHRcdFx0dGhpcy5zdG9wV2F0Y2goKTtcclxuXHRcdFx0cmV0dXJuIHNvcnRlZExpc3Q7XHJcblx0XHR9XHJcblx0fVxyXG59Il19
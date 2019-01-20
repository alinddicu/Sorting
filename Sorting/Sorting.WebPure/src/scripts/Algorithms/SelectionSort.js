var Algorithms;
(function (Algorithms) {
    class SelectionSort extends Algorithms.SortBase {
        execute(unsortedList) {
            super.execute(unsortedList);
            const sortedList = super.copy(unsortedList);
            super.addToIntermediateSorts(unsortedList);
            const count = sortedList.length;
            for (let i = count - 1; i >= 0; i--) {
                const minValue = this.getMin(sortedList, i);
                sortedList.splice(minValue.position, 1);
                sortedList.push(minValue.value);
                this.addToIntermediateSorts(sortedList);
            }
            this.stopWatch();
            return sortedList;
        }
        getMin(values, limit) {
            let position = 0;
            let min = values[position];
            for (var i = 0; i <= limit; i++) {
                var item = values[i];
                if (item >= min) {
                    continue;
                }
                min = item;
                position = i;
            }
            return new MinValue(min, position);
        }
    }
    Algorithms.SelectionSort = SelectionSort;
    class MinValue {
        constructor(value, position) {
            this.value = value;
            this.position = position;
        }
    }
})(Algorithms || (Algorithms = {}));
//# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiU2VsZWN0aW9uU29ydC5qcyIsInNvdXJjZVJvb3QiOiIiLCJzb3VyY2VzIjpbIlNlbGVjdGlvblNvcnQudHMiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUEsSUFBVSxVQUFVLENBK0NuQjtBQS9DRCxXQUFVLFVBQVU7SUFDbkIsbUJBQTJCLFNBQVEsV0FBQSxRQUFRO1FBQ25DLE9BQU8sQ0FBQyxZQUFzQjtZQUNwQyxLQUFLLENBQUMsT0FBTyxDQUFDLFlBQVksQ0FBQyxDQUFDO1lBQzVCLE1BQU0sVUFBVSxHQUFHLEtBQUssQ0FBQyxJQUFJLENBQUMsWUFBWSxDQUFDLENBQUM7WUFDNUMsS0FBSyxDQUFDLHNCQUFzQixDQUFDLFlBQVksQ0FBQyxDQUFDO1lBRTNDLE1BQU0sS0FBSyxHQUFHLFVBQVUsQ0FBQyxNQUFNLENBQUM7WUFDaEMsR0FBRyxDQUFDLENBQUMsSUFBSSxDQUFDLEdBQUcsS0FBSyxHQUFHLENBQUMsRUFBRSxDQUFDLElBQUksQ0FBQyxFQUFFLENBQUMsRUFBRSxFQUFFLENBQUM7Z0JBQ3JDLE1BQU0sUUFBUSxHQUFHLElBQUksQ0FBQyxNQUFNLENBQUMsVUFBVSxFQUFFLENBQUMsQ0FBQyxDQUFDO2dCQUM1QyxVQUFVLENBQUMsTUFBTSxDQUFDLFFBQVEsQ0FBQyxRQUFRLEVBQUUsQ0FBQyxDQUFDLENBQUM7Z0JBQ3hDLFVBQVUsQ0FBQyxJQUFJLENBQUMsUUFBUSxDQUFDLEtBQUssQ0FBQyxDQUFDO2dCQUVoQyxJQUFJLENBQUMsc0JBQXNCLENBQUMsVUFBVSxDQUFDLENBQUM7WUFDekMsQ0FBQztZQUVELElBQUksQ0FBQyxTQUFTLEVBQUUsQ0FBQztZQUNqQixNQUFNLENBQUMsVUFBVSxDQUFDO1FBQ25CLENBQUM7UUFFTyxNQUFNLENBQUMsTUFBZ0IsRUFBRSxLQUFhO1lBQzdDLElBQUksUUFBUSxHQUFHLENBQUMsQ0FBQztZQUNqQixJQUFJLEdBQUcsR0FBRyxNQUFNLENBQUMsUUFBUSxDQUFDLENBQUM7WUFDM0IsR0FBRyxDQUFDLENBQUMsSUFBSSxDQUFDLEdBQUcsQ0FBQyxFQUFFLENBQUMsSUFBSSxLQUFLLEVBQUUsQ0FBQyxFQUFFLEVBQUUsQ0FBQztnQkFDakMsSUFBSSxJQUFJLEdBQUcsTUFBTSxDQUFDLENBQUMsQ0FBQyxDQUFDO2dCQUNyQixFQUFFLENBQUMsQ0FBQyxJQUFJLElBQUksR0FBRyxDQUFDLENBQUMsQ0FBQztvQkFDakIsUUFBUSxDQUFDO2dCQUNWLENBQUM7Z0JBRUQsR0FBRyxHQUFHLElBQUksQ0FBQztnQkFDWCxRQUFRLEdBQUcsQ0FBQyxDQUFDO1lBQ2QsQ0FBQztZQUVELE1BQU0sQ0FBQyxJQUFJLFFBQVEsQ0FBQyxHQUFHLEVBQUUsUUFBUSxDQUFDLENBQUM7UUFDcEMsQ0FBQztLQUNEO0lBbENZLHdCQUFhLGdCQWtDekIsQ0FBQTtJQUVEO1FBS0MsWUFBWSxLQUFhLEVBQUUsUUFBZ0I7WUFDMUMsSUFBSSxDQUFDLEtBQUssR0FBRyxLQUFLLENBQUM7WUFDbkIsSUFBSSxDQUFDLFFBQVEsR0FBRyxRQUFRLENBQUM7UUFDMUIsQ0FBQztLQUNEO0FBQ0YsQ0FBQyxFQS9DUyxVQUFVLEtBQVYsVUFBVSxRQStDbkIiLCJzb3VyY2VzQ29udGVudCI6WyJuYW1lc3BhY2UgQWxnb3JpdGhtcyB7XHJcblx0ZXhwb3J0IGNsYXNzIFNlbGVjdGlvblNvcnQgZXh0ZW5kcyBTb3J0QmFzZSB7XHJcblx0XHRwdWJsaWMgZXhlY3V0ZSh1bnNvcnRlZExpc3Q6IG51bWJlcltdKTogbnVtYmVyW10ge1xyXG5cdFx0XHRzdXBlci5leGVjdXRlKHVuc29ydGVkTGlzdCk7XHJcblx0XHRcdGNvbnN0IHNvcnRlZExpc3QgPSBzdXBlci5jb3B5KHVuc29ydGVkTGlzdCk7XHJcblx0XHRcdHN1cGVyLmFkZFRvSW50ZXJtZWRpYXRlU29ydHModW5zb3J0ZWRMaXN0KTtcclxuXHJcblx0XHRcdGNvbnN0IGNvdW50ID0gc29ydGVkTGlzdC5sZW5ndGg7XHJcblx0XHRcdGZvciAobGV0IGkgPSBjb3VudCAtIDE7IGkgPj0gMDsgaS0tKSB7XHJcblx0XHRcdFx0Y29uc3QgbWluVmFsdWUgPSB0aGlzLmdldE1pbihzb3J0ZWRMaXN0LCBpKTtcclxuXHRcdFx0XHRzb3J0ZWRMaXN0LnNwbGljZShtaW5WYWx1ZS5wb3NpdGlvbiwgMSk7XHJcblx0XHRcdFx0c29ydGVkTGlzdC5wdXNoKG1pblZhbHVlLnZhbHVlKTtcclxuXHJcblx0XHRcdFx0dGhpcy5hZGRUb0ludGVybWVkaWF0ZVNvcnRzKHNvcnRlZExpc3QpO1xyXG5cdFx0XHR9XHJcblxyXG5cdFx0XHR0aGlzLnN0b3BXYXRjaCgpO1xyXG5cdFx0XHRyZXR1cm4gc29ydGVkTGlzdDtcclxuXHRcdH1cclxuXHJcblx0XHRwcml2YXRlIGdldE1pbih2YWx1ZXM6IG51bWJlcltdLCBsaW1pdDogbnVtYmVyKTogTWluVmFsdWUge1xyXG5cdFx0XHRsZXQgcG9zaXRpb24gPSAwO1xyXG5cdFx0XHRsZXQgbWluID0gdmFsdWVzW3Bvc2l0aW9uXTtcclxuXHRcdFx0Zm9yICh2YXIgaSA9IDA7IGkgPD0gbGltaXQ7IGkrKykge1xyXG5cdFx0XHRcdHZhciBpdGVtID0gdmFsdWVzW2ldO1xyXG5cdFx0XHRcdGlmIChpdGVtID49IG1pbikge1xyXG5cdFx0XHRcdFx0Y29udGludWU7XHJcblx0XHRcdFx0fVxyXG5cclxuXHRcdFx0XHRtaW4gPSBpdGVtO1xyXG5cdFx0XHRcdHBvc2l0aW9uID0gaTtcclxuXHRcdFx0fVxyXG5cclxuXHRcdFx0cmV0dXJuIG5ldyBNaW5WYWx1ZShtaW4sIHBvc2l0aW9uKTtcclxuXHRcdH1cclxuXHR9XHJcblxyXG5cdGNsYXNzIE1pblZhbHVlIHtcclxuXHJcblx0XHR2YWx1ZTogbnVtYmVyO1xyXG5cdFx0cG9zaXRpb246IG51bWJlcjtcclxuXHJcblx0XHRjb25zdHJ1Y3Rvcih2YWx1ZTogbnVtYmVyLCBwb3NpdGlvbjogbnVtYmVyKSB7XHJcblx0XHRcdHRoaXMudmFsdWUgPSB2YWx1ZTtcclxuXHRcdFx0dGhpcy5wb3NpdGlvbiA9IHBvc2l0aW9uO1xyXG5cdFx0fVxyXG5cdH1cclxufSJdfQ==
var Algorithms;
(function (Algorithms) {
    class HeapSort extends Algorithms.SortBase {
        execute(unsortedList) {
            super.execute(unsortedList);
            this.arrayCopy = super.copy(unsortedList);
            super.addToIntermediateSorts(this.arrayCopy);
            this.sort(this.arrayCopy);
            this.stopWatch();
            return this.arrayCopy;
        }
        sort(arr) {
            const n = arr.length;
            // Build heap (rearrange array) 
            for (let i = n / 2 - 1; i >= 0; i--) {
                this.heapify(arr, n, i);
                this.addToIntermediateSorts(this.arrayCopy);
            }
            // One by one extract an element from heap 
            for (let i = n - 1; i >= 0; i--) {
                // Move current root to end 
                const temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                // call max heapify on the reduced heap 
                this.heapify(arr, i, 0);
                this.addToIntermediateSorts(this.arrayCopy);
            }
        }
        // To heapify a subtree rooted with node i which is 
        // an index in arr[]. n is size of heap 
        heapify(arr, n, i) {
            while (true) {
                let largest = i;
                // Initialize largest as root 
                const left = 2 * i + 1;
                // left = 2*i + 1 
                const right = 2 * i + 2;
                // right = 2*i + 2 
                // If left child is larger than root 
                if (left < n && arr[left] > arr[largest])
                    largest = left;
                // If right child is larger than largest so far 
                if (right < n && arr[right] > arr[largest])
                    largest = right;
                // If largest is not root 
                if (largest === i) {
                    return;
                }
                const swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                // Recursively heapify the affected sub-tree 
                i = largest;
            }
        }
    }
    Algorithms.HeapSort = HeapSort;
})(Algorithms || (Algorithms = {}));
//# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiSGVhcFNvcnQuanMiLCJzb3VyY2VSb290IjoiIiwic291cmNlcyI6WyJIZWFwU29ydC50cyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQSxJQUFVLFVBQVUsQ0F5RW5CO0FBekVELFdBQVUsVUFBVTtJQUNuQixjQUFzQixTQUFRLFdBQUEsUUFBUTtRQUc5QixPQUFPLENBQUMsWUFBc0I7WUFFckMsS0FBSyxDQUFDLE9BQU8sQ0FBQyxZQUFZLENBQUMsQ0FBQztZQUM1QixJQUFJLENBQUMsU0FBUyxHQUFHLEtBQUssQ0FBQyxJQUFJLENBQUMsWUFBWSxDQUFDLENBQUM7WUFDMUMsS0FBSyxDQUFDLHNCQUFzQixDQUFDLElBQUksQ0FBQyxTQUFTLENBQUMsQ0FBQztZQUU3QyxJQUFJLENBQUMsSUFBSSxDQUFDLElBQUksQ0FBQyxTQUFTLENBQUMsQ0FBQztZQUUxQixJQUFJLENBQUMsU0FBUyxFQUFFLENBQUM7WUFDakIsTUFBTSxDQUFDLElBQUksQ0FBQyxTQUFTLENBQUM7UUFDdkIsQ0FBQztRQUVRLElBQUksQ0FBQyxHQUFhO1lBRXpCLE1BQU0sQ0FBQyxHQUFHLEdBQUcsQ0FBQyxNQUFNLENBQUM7WUFFckIsZ0NBQWdDO1lBQ2hDLEdBQUcsQ0FBQyxDQUFDLElBQUksQ0FBQyxHQUFHLENBQUMsR0FBRyxDQUFDLEdBQUcsQ0FBQyxFQUFFLENBQUMsSUFBSSxDQUFDLEVBQUUsQ0FBQyxFQUFFLEVBQUUsQ0FBQztnQkFDckMsSUFBSSxDQUFDLE9BQU8sQ0FBQyxHQUFHLEVBQUUsQ0FBQyxFQUFFLENBQUMsQ0FBQyxDQUFDO2dCQUN4QixJQUFJLENBQUMsc0JBQXNCLENBQUMsSUFBSSxDQUFDLFNBQVMsQ0FBQyxDQUFDO1lBQzdDLENBQUM7WUFFRCwyQ0FBMkM7WUFDM0MsR0FBRyxDQUFDLENBQUMsSUFBSSxDQUFDLEdBQUcsQ0FBQyxHQUFHLENBQUMsRUFBRSxDQUFDLElBQUksQ0FBQyxFQUFFLENBQUMsRUFBRSxFQUFFLENBQUM7Z0JBQ2pDLDRCQUE0QjtnQkFDNUIsTUFBTSxJQUFJLEdBQUcsR0FBRyxDQUFDLENBQUMsQ0FBQyxDQUFDO2dCQUNwQixHQUFHLENBQUMsQ0FBQyxDQUFDLEdBQUcsR0FBRyxDQUFDLENBQUMsQ0FBQyxDQUFDO2dCQUNoQixHQUFHLENBQUMsQ0FBQyxDQUFDLEdBQUcsSUFBSSxDQUFDO2dCQUVkLHdDQUF3QztnQkFDeEMsSUFBSSxDQUFDLE9BQU8sQ0FBQyxHQUFHLEVBQUUsQ0FBQyxFQUFFLENBQUMsQ0FBQyxDQUFDO2dCQUN4QixJQUFJLENBQUMsc0JBQXNCLENBQUMsSUFBSSxDQUFDLFNBQVMsQ0FBQyxDQUFDO1lBQzdDLENBQUM7UUFDRixDQUFDO1FBRUQsb0RBQW9EO1FBQ3BELHdDQUF3QztRQUNoQyxPQUFPLENBQUMsR0FBYSxFQUFFLENBQVMsRUFBRSxDQUFTO1lBRWxELE9BQU8sSUFBSSxFQUFFLENBQUM7Z0JBQ2IsSUFBSSxPQUFPLEdBQUcsQ0FBQyxDQUFDO2dCQUNoQiw4QkFBOEI7Z0JBQzlCLE1BQU0sSUFBSSxHQUFHLENBQUMsR0FBRyxDQUFDLEdBQUcsQ0FBQyxDQUFDO2dCQUN2QixrQkFBa0I7Z0JBQ2xCLE1BQU0sS0FBSyxHQUFHLENBQUMsR0FBRyxDQUFDLEdBQUcsQ0FBQyxDQUFDO2dCQUN4QixtQkFBbUI7Z0JBRW5CLHFDQUFxQztnQkFDckMsRUFBRSxDQUFDLENBQUMsSUFBSSxHQUFHLENBQUMsSUFBSSxHQUFHLENBQUMsSUFBSSxDQUFDLEdBQUcsR0FBRyxDQUFDLE9BQU8sQ0FBQyxDQUFDO29CQUN4QyxPQUFPLEdBQUcsSUFBSSxDQUFDO2dCQUVoQixnREFBZ0Q7Z0JBQ2hELEVBQUUsQ0FBQyxDQUFDLEtBQUssR0FBRyxDQUFDLElBQUksR0FBRyxDQUFDLEtBQUssQ0FBQyxHQUFHLEdBQUcsQ0FBQyxPQUFPLENBQUMsQ0FBQztvQkFDMUMsT0FBTyxHQUFHLEtBQUssQ0FBQztnQkFFakIsMEJBQTBCO2dCQUMxQixFQUFFLENBQUMsQ0FBQyxPQUFPLEtBQUssQ0FBQyxDQUFDLENBQUMsQ0FBQztvQkFDbkIsTUFBTSxDQUFDO2dCQUNSLENBQUM7Z0JBRUQsTUFBTSxJQUFJLEdBQUcsR0FBRyxDQUFDLENBQUMsQ0FBQyxDQUFDO2dCQUNwQixHQUFHLENBQUMsQ0FBQyxDQUFDLEdBQUcsR0FBRyxDQUFDLE9BQU8sQ0FBQyxDQUFDO2dCQUN0QixHQUFHLENBQUMsT0FBTyxDQUFDLEdBQUcsSUFBSSxDQUFDO2dCQUVwQiw2Q0FBNkM7Z0JBQzdDLENBQUMsR0FBRyxPQUFPLENBQUM7WUFDYixDQUFDO1FBQ0YsQ0FBQztLQUNEO0lBdkVZLG1CQUFRLFdBdUVwQixDQUFBO0FBQ0YsQ0FBQyxFQXpFUyxVQUFVLEtBQVYsVUFBVSxRQXlFbkIiLCJzb3VyY2VzQ29udGVudCI6WyJuYW1lc3BhY2UgQWxnb3JpdGhtcyB7XHJcblx0ZXhwb3J0IGNsYXNzIEhlYXBTb3J0IGV4dGVuZHMgU29ydEJhc2Uge1xyXG5cdFx0cHJpdmF0ZSBhcnJheUNvcHk6IG51bWJlcltdO1xyXG5cclxuXHRcdHB1YmxpYyBleGVjdXRlKHVuc29ydGVkTGlzdDogbnVtYmVyW10pOiBudW1iZXJbXSB7XHJcblx0XHJcblx0XHRzdXBlci5leGVjdXRlKHVuc29ydGVkTGlzdCk7XHJcblx0XHR0aGlzLmFycmF5Q29weSA9IHN1cGVyLmNvcHkodW5zb3J0ZWRMaXN0KTtcclxuXHRcdHN1cGVyLmFkZFRvSW50ZXJtZWRpYXRlU29ydHModGhpcy5hcnJheUNvcHkpO1xyXG5cclxuXHRcdHRoaXMuc29ydCh0aGlzLmFycmF5Q29weSk7XHJcblxyXG5cdFx0dGhpcy5zdG9wV2F0Y2goKTtcclxuXHRcdHJldHVybiB0aGlzLmFycmF5Q29weTtcclxuXHR9XHJcblxyXG5cdFx0cHJpdmF0ZSBzb3J0KGFycjogbnVtYmVyW10pOnZvaWRcclxuXHRcdHtcclxuXHRcdFx0Y29uc3QgbiA9IGFyci5sZW5ndGg7XHJcblxyXG5cdFx0XHQvLyBCdWlsZCBoZWFwIChyZWFycmFuZ2UgYXJyYXkpIFxyXG5cdFx0XHRmb3IgKGxldCBpID0gbiAvIDIgLSAxOyBpID49IDA7IGktLSkge1xyXG5cdFx0XHRcdHRoaXMuaGVhcGlmeShhcnIsIG4sIGkpO1xyXG5cdFx0XHRcdHRoaXMuYWRkVG9JbnRlcm1lZGlhdGVTb3J0cyh0aGlzLmFycmF5Q29weSk7XHJcblx0XHRcdH1cclxuXHJcblx0XHRcdC8vIE9uZSBieSBvbmUgZXh0cmFjdCBhbiBlbGVtZW50IGZyb20gaGVhcCBcclxuXHRcdFx0Zm9yIChsZXQgaSA9IG4gLSAxOyBpID49IDA7IGktLSkge1xyXG5cdFx0XHRcdC8vIE1vdmUgY3VycmVudCByb290IHRvIGVuZCBcclxuXHRcdFx0XHRjb25zdCB0ZW1wID0gYXJyWzBdO1xyXG5cdFx0XHRcdGFyclswXSA9IGFycltpXTtcclxuXHRcdFx0XHRhcnJbaV0gPSB0ZW1wO1xyXG5cclxuXHRcdFx0XHQvLyBjYWxsIG1heCBoZWFwaWZ5IG9uIHRoZSByZWR1Y2VkIGhlYXAgXHJcblx0XHRcdFx0dGhpcy5oZWFwaWZ5KGFyciwgaSwgMCk7XHJcblx0XHRcdFx0dGhpcy5hZGRUb0ludGVybWVkaWF0ZVNvcnRzKHRoaXMuYXJyYXlDb3B5KTtcclxuXHRcdFx0fVxyXG5cdFx0fVxyXG5cclxuXHRcdC8vIFRvIGhlYXBpZnkgYSBzdWJ0cmVlIHJvb3RlZCB3aXRoIG5vZGUgaSB3aGljaCBpcyBcclxuXHRcdC8vIGFuIGluZGV4IGluIGFycltdLiBuIGlzIHNpemUgb2YgaGVhcCBcclxuXHRcdHByaXZhdGUgaGVhcGlmeShhcnI6IG51bWJlcltdLCBuOiBudW1iZXIsIGk6IG51bWJlcik6IHZvaWRcclxuXHRcdHtcclxuXHRcdFx0d2hpbGUgKHRydWUpIHtcclxuXHRcdFx0XHRsZXQgbGFyZ2VzdCA9IGk7XHJcblx0XHRcdFx0Ly8gSW5pdGlhbGl6ZSBsYXJnZXN0IGFzIHJvb3QgXHJcblx0XHRcdFx0Y29uc3QgbGVmdCA9IDIgKiBpICsgMTtcclxuXHRcdFx0XHQvLyBsZWZ0ID0gMippICsgMSBcclxuXHRcdFx0XHRjb25zdCByaWdodCA9IDIgKiBpICsgMjtcclxuXHRcdFx0XHQvLyByaWdodCA9IDIqaSArIDIgXHJcblxyXG5cdFx0XHRcdC8vIElmIGxlZnQgY2hpbGQgaXMgbGFyZ2VyIHRoYW4gcm9vdCBcclxuXHRcdFx0XHRpZiAobGVmdCA8IG4gJiYgYXJyW2xlZnRdID4gYXJyW2xhcmdlc3RdKVxyXG5cdFx0XHRcdFx0bGFyZ2VzdCA9IGxlZnQ7XHJcblxyXG5cdFx0XHRcdC8vIElmIHJpZ2h0IGNoaWxkIGlzIGxhcmdlciB0aGFuIGxhcmdlc3Qgc28gZmFyIFxyXG5cdFx0XHRcdGlmIChyaWdodCA8IG4gJiYgYXJyW3JpZ2h0XSA+IGFycltsYXJnZXN0XSlcclxuXHRcdFx0XHRcdGxhcmdlc3QgPSByaWdodDtcclxuXHJcblx0XHRcdFx0Ly8gSWYgbGFyZ2VzdCBpcyBub3Qgcm9vdCBcclxuXHRcdFx0XHRpZiAobGFyZ2VzdCA9PT0gaSkge1xyXG5cdFx0XHRcdFx0cmV0dXJuO1xyXG5cdFx0XHRcdH1cclxuXHJcblx0XHRcdFx0Y29uc3Qgc3dhcCA9IGFycltpXTtcclxuXHRcdFx0XHRhcnJbaV0gPSBhcnJbbGFyZ2VzdF07XHJcblx0XHRcdFx0YXJyW2xhcmdlc3RdID0gc3dhcDtcclxuXHJcblx0XHRcdFx0Ly8gUmVjdXJzaXZlbHkgaGVhcGlmeSB0aGUgYWZmZWN0ZWQgc3ViLXRyZWUgXHJcblx0XHRcdFx0aSA9IGxhcmdlc3Q7XHJcblx0XHRcdH1cclxuXHRcdH1cclxuXHR9XHJcbn0iXX0=
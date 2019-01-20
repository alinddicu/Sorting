var Tools;
(function (Tools) {
    class RandomArrayGenerator {
        Generate(length, start) {
            const array = [];
            for (let i = start; i < length + start; i++) {
                array.push(i);
            }
            return this.shuffle(array);
        }
        shuffle(array) {
            let tmp;
            let current;
            let top = array.length;
            if (top)
                while (--top) {
                    current = Math.floor(Math.random() * (top + 1));
                    tmp = array[current];
                    array[current] = array[top];
                    array[top] = tmp;
                }
            return array;
        }
    }
    Tools.RandomArrayGenerator = RandomArrayGenerator;
})(Tools || (Tools = {}));
//# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiUmFuZG9tQXJyYXlHZW5lcmF0b3IuanMiLCJzb3VyY2VSb290IjoiIiwic291cmNlcyI6WyJSYW5kb21BcnJheUdlbmVyYXRvci50cyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQSxJQUFVLEtBQUssQ0F5QmQ7QUF6QkQsV0FBVSxLQUFLO0lBQ2Q7UUFDUSxRQUFRLENBQUMsTUFBYyxFQUFFLEtBQWE7WUFDNUMsTUFBTSxLQUFLLEdBQUcsRUFBRSxDQUFDO1lBQ2pCLEdBQUcsQ0FBQyxDQUFDLElBQUksQ0FBQyxHQUFHLEtBQUssRUFBRSxDQUFDLEdBQUcsTUFBTSxHQUFHLEtBQUssRUFBRSxDQUFDLEVBQUUsRUFBRSxDQUFDO2dCQUM3QyxLQUFLLENBQUMsSUFBSSxDQUFDLENBQUMsQ0FBQyxDQUFDO1lBQ2YsQ0FBQztZQUVELE1BQU0sQ0FBQyxJQUFJLENBQUMsT0FBTyxDQUFDLEtBQUssQ0FBQyxDQUFDO1FBQzVCLENBQUM7UUFFTyxPQUFPLENBQUMsS0FBZTtZQUM5QixJQUFJLEdBQUcsQ0FBQztZQUNSLElBQUksT0FBZSxDQUFDO1lBQ3BCLElBQUksR0FBRyxHQUFHLEtBQUssQ0FBQyxNQUFNLENBQUM7WUFDdkIsRUFBRSxDQUFDLENBQUMsR0FBRyxDQUFDO2dCQUFDLE9BQU8sRUFBRSxHQUFHLEVBQUUsQ0FBQztvQkFDdkIsT0FBTyxHQUFHLElBQUksQ0FBQyxLQUFLLENBQUMsSUFBSSxDQUFDLE1BQU0sRUFBRSxHQUFHLENBQUMsR0FBRyxHQUFHLENBQUMsQ0FBQyxDQUFDLENBQUM7b0JBQ2hELEdBQUcsR0FBRyxLQUFLLENBQUMsT0FBTyxDQUFDLENBQUM7b0JBQ3JCLEtBQUssQ0FBQyxPQUFPLENBQUMsR0FBRyxLQUFLLENBQUMsR0FBRyxDQUFDLENBQUM7b0JBQzVCLEtBQUssQ0FBQyxHQUFHLENBQUMsR0FBRyxHQUFHLENBQUM7Z0JBQ2xCLENBQUM7WUFFRCxNQUFNLENBQUMsS0FBSyxDQUFDO1FBQ2QsQ0FBQztLQUNEO0lBdkJZLDBCQUFvQix1QkF1QmhDLENBQUE7QUFDRixDQUFDLEVBekJTLEtBQUssS0FBTCxLQUFLLFFBeUJkIiwic291cmNlc0NvbnRlbnQiOlsibmFtZXNwYWNlIFRvb2xzIHtcclxuXHRleHBvcnQgY2xhc3MgUmFuZG9tQXJyYXlHZW5lcmF0b3Ige1xyXG5cdFx0cHVibGljIEdlbmVyYXRlKGxlbmd0aDogbnVtYmVyLCBzdGFydDogbnVtYmVyKTogbnVtYmVyW10ge1xyXG5cdFx0XHRjb25zdCBhcnJheSA9IFtdO1xyXG5cdFx0XHRmb3IgKGxldCBpID0gc3RhcnQ7IGkgPCBsZW5ndGggKyBzdGFydDsgaSsrKSB7XHJcblx0XHRcdFx0YXJyYXkucHVzaChpKTtcclxuXHRcdFx0fVxyXG5cclxuXHRcdFx0cmV0dXJuIHRoaXMuc2h1ZmZsZShhcnJheSk7XHJcblx0XHR9XHJcblxyXG5cdFx0cHJpdmF0ZSBzaHVmZmxlKGFycmF5OiBudW1iZXJbXSk6IG51bWJlcltdIHtcclxuXHRcdFx0bGV0IHRtcDtcclxuXHRcdFx0bGV0IGN1cnJlbnQ6IG51bWJlcjtcclxuXHRcdFx0bGV0IHRvcCA9IGFycmF5Lmxlbmd0aDtcclxuXHRcdFx0aWYgKHRvcCkgd2hpbGUgKC0tdG9wKSB7XHJcblx0XHRcdFx0Y3VycmVudCA9IE1hdGguZmxvb3IoTWF0aC5yYW5kb20oKSAqICh0b3AgKyAxKSk7XHJcblx0XHRcdFx0dG1wID0gYXJyYXlbY3VycmVudF07XHJcblx0XHRcdFx0YXJyYXlbY3VycmVudF0gPSBhcnJheVt0b3BdO1xyXG5cdFx0XHRcdGFycmF5W3RvcF0gPSB0bXA7XHJcblx0XHRcdH1cclxuXHJcblx0XHRcdHJldHVybiBhcnJheTtcclxuXHRcdH1cclxuXHR9XHJcbn0iXX0=
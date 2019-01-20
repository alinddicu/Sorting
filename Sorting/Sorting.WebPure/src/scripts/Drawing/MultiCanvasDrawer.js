var Drawing;
(function (Drawing) {
    class MultiCanvasDrawer {
        constructor(document, drawParams) {
            this.document = document;
            let rankingSystem = new Tools.RankingSystem();
            this.sortings = [
                new Algorithms.BubbleSort(rankingSystem),
                new Algorithms.InsertionSort(rankingSystem),
                new Algorithms.HeapSort(rankingSystem),
                new Algorithms.MergeSort(rankingSystem),
                new Algorithms.QuickSort(rankingSystem),
                new Algorithms.SelectionSort(rankingSystem)
            ];
            this.drawParams = drawParams;
        }
        draw(arrayToSort) {
            for (let sorting of this.sortings) {
                sorting.execute(arrayToSort);
                new Drawing.SingleCanvasDrawer(sorting, this.document).draw(this.drawParams);
            }
        }
    }
    Drawing.MultiCanvasDrawer = MultiCanvasDrawer;
})(Drawing || (Drawing = {}));
//# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiTXVsdGlDYW52YXNEcmF3ZXIuanMiLCJzb3VyY2VSb290IjoiIiwic291cmNlcyI6WyJNdWx0aUNhbnZhc0RyYXdlci50cyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQSxJQUFVLE9BQU8sQ0E2QmhCO0FBN0JELFdBQVUsT0FBTztJQUdoQjtRQUtDLFlBQVksUUFBa0IsRUFBRSxVQUEwQjtZQUN6RCxJQUFJLENBQUMsUUFBUSxHQUFHLFFBQVEsQ0FBQztZQUN6QixJQUFJLGFBQWEsR0FBRyxJQUFJLEtBQUssQ0FBQyxhQUFhLEVBQUUsQ0FBQztZQUM5QyxJQUFJLENBQUMsUUFBUSxHQUFHO2dCQUNmLElBQUksVUFBVSxDQUFDLFVBQVUsQ0FBQyxhQUFhLENBQUM7Z0JBQ3hDLElBQUksVUFBVSxDQUFDLGFBQWEsQ0FBQyxhQUFhLENBQUM7Z0JBQzNDLElBQUksVUFBVSxDQUFDLFFBQVEsQ0FBQyxhQUFhLENBQUM7Z0JBQ3RDLElBQUksVUFBVSxDQUFDLFNBQVMsQ0FBQyxhQUFhLENBQUM7Z0JBQ3ZDLElBQUksVUFBVSxDQUFDLFNBQVMsQ0FBQyxhQUFhLENBQUM7Z0JBQ3ZDLElBQUksVUFBVSxDQUFDLGFBQWEsQ0FBQyxhQUFhLENBQUM7YUFDM0MsQ0FBQztZQUNGLElBQUksQ0FBQyxVQUFVLEdBQUcsVUFBVSxDQUFDO1FBQzlCLENBQUM7UUFFTSxJQUFJLENBQUMsV0FBcUI7WUFDaEMsR0FBRyxDQUFDLENBQUMsSUFBSSxPQUFPLElBQUksSUFBSSxDQUFDLFFBQVEsQ0FBQyxDQUFDLENBQUM7Z0JBQ25DLE9BQU8sQ0FBQyxPQUFPLENBQUMsV0FBVyxDQUFDLENBQUM7Z0JBQzdCLElBQUksUUFBQSxrQkFBa0IsQ0FBQyxPQUFPLEVBQUUsSUFBSSxDQUFDLFFBQVEsQ0FBQyxDQUFDLElBQUksQ0FBQyxJQUFJLENBQUMsVUFBVSxDQUFDLENBQUM7WUFDdEUsQ0FBQztRQUNGLENBQUM7S0FDRDtJQXpCWSx5QkFBaUIsb0JBeUI3QixDQUFBO0FBQ0YsQ0FBQyxFQTdCUyxPQUFPLEtBQVAsT0FBTyxRQTZCaEIiLCJzb3VyY2VzQ29udGVudCI6WyJuYW1lc3BhY2UgRHJhd2luZyB7XHJcblx0aW1wb3J0IFNvcnRCYXNlID0gQWxnb3JpdGhtcy5Tb3J0QmFzZTtcclxuXHJcblx0ZXhwb3J0IGNsYXNzIE11bHRpQ2FudmFzRHJhd2VyIHtcclxuXHRcdHByaXZhdGUgZG9jdW1lbnQ6IERvY3VtZW50O1xyXG5cdFx0cHJpdmF0ZSBzb3J0aW5nczogU29ydEJhc2VbXTtcclxuXHRcdHByaXZhdGUgZHJhd1BhcmFtczogSURyYXdpbmdQYXJhbXM7XHJcblxyXG5cdFx0Y29uc3RydWN0b3IoZG9jdW1lbnQ6IERvY3VtZW50LCBkcmF3UGFyYW1zOiBJRHJhd2luZ1BhcmFtcykge1xyXG5cdFx0XHR0aGlzLmRvY3VtZW50ID0gZG9jdW1lbnQ7XHJcblx0XHRcdGxldCByYW5raW5nU3lzdGVtID0gbmV3IFRvb2xzLlJhbmtpbmdTeXN0ZW0oKTtcclxuXHRcdFx0dGhpcy5zb3J0aW5ncyA9IFtcclxuXHRcdFx0XHRuZXcgQWxnb3JpdGhtcy5CdWJibGVTb3J0KHJhbmtpbmdTeXN0ZW0pLFxyXG5cdFx0XHRcdG5ldyBBbGdvcml0aG1zLkluc2VydGlvblNvcnQocmFua2luZ1N5c3RlbSksXHJcblx0XHRcdFx0bmV3IEFsZ29yaXRobXMuSGVhcFNvcnQocmFua2luZ1N5c3RlbSksXHJcblx0XHRcdFx0bmV3IEFsZ29yaXRobXMuTWVyZ2VTb3J0KHJhbmtpbmdTeXN0ZW0pLFxyXG5cdFx0XHRcdG5ldyBBbGdvcml0aG1zLlF1aWNrU29ydChyYW5raW5nU3lzdGVtKSxcclxuXHRcdFx0XHRuZXcgQWxnb3JpdGhtcy5TZWxlY3Rpb25Tb3J0KHJhbmtpbmdTeXN0ZW0pXHJcblx0XHRcdF07XHJcblx0XHRcdHRoaXMuZHJhd1BhcmFtcyA9IGRyYXdQYXJhbXM7XHJcblx0XHR9XHJcblxyXG5cdFx0cHVibGljIGRyYXcoYXJyYXlUb1NvcnQ6IG51bWJlcltdKTogdm9pZCB7XHJcblx0XHRcdGZvciAobGV0IHNvcnRpbmcgb2YgdGhpcy5zb3J0aW5ncykge1xyXG5cdFx0XHRcdHNvcnRpbmcuZXhlY3V0ZShhcnJheVRvU29ydCk7XHJcblx0XHRcdFx0bmV3IFNpbmdsZUNhbnZhc0RyYXdlcihzb3J0aW5nLCB0aGlzLmRvY3VtZW50KS5kcmF3KHRoaXMuZHJhd1BhcmFtcyk7XHJcblx0XHRcdH1cclxuXHRcdH1cclxuXHR9XHJcbn0iXX0=
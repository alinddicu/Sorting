var Tools;
(function (Tools) {
    class OrdinalHelper {
        static toOrdinal(numberToFormat) {
            if (numberToFormat < 0)
                return numberToFormat.toString();
            const rem = numberToFormat % 100;
            if (rem >= 11 && rem <= 13)
                return numberToFormat + "th";
            switch (numberToFormat % 10) {
                case 1:
                    return numberToFormat + "st";
                case 2:
                    return numberToFormat + "nd";
                case 3:
                    return numberToFormat + "rd";
                default:
                    return numberToFormat + "th";
            }
        }
    }
    Tools.OrdinalHelper = OrdinalHelper;
})(Tools || (Tools = {}));
//# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiT3JkaW5hbEhlbHBlci5qcyIsInNvdXJjZVJvb3QiOiIiLCJzb3VyY2VzIjpbIk9yZGluYWxIZWxwZXIudHMiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUEsSUFBVSxLQUFLLENBcUJkO0FBckJELFdBQVUsS0FBSztJQUVkO1FBRVEsTUFBTSxDQUFDLFNBQVMsQ0FBQyxjQUFzQjtZQUM3QyxFQUFFLENBQUMsQ0FBQyxjQUFjLEdBQUcsQ0FBQyxDQUFDO2dCQUFDLE1BQU0sQ0FBQyxjQUFjLENBQUMsUUFBUSxFQUFFLENBQUM7WUFDekQsTUFBTSxHQUFHLEdBQUcsY0FBYyxHQUFHLEdBQUcsQ0FBQztZQUNqQyxFQUFFLENBQUMsQ0FBQyxHQUFHLElBQUksRUFBRSxJQUFJLEdBQUcsSUFBSSxFQUFFLENBQUM7Z0JBQUMsTUFBTSxDQUFDLGNBQWMsR0FBRyxJQUFJLENBQUM7WUFFekQsTUFBTSxDQUFDLENBQUMsY0FBYyxHQUFHLEVBQUUsQ0FBQyxDQUFDLENBQUM7Z0JBQzdCLEtBQUssQ0FBQztvQkFDTCxNQUFNLENBQUMsY0FBYyxHQUFHLElBQUksQ0FBQztnQkFDOUIsS0FBSyxDQUFDO29CQUNMLE1BQU0sQ0FBQyxjQUFjLEdBQUcsSUFBSSxDQUFDO2dCQUM5QixLQUFLLENBQUM7b0JBQ0wsTUFBTSxDQUFDLGNBQWMsR0FBRyxJQUFJLENBQUM7Z0JBQzlCO29CQUNDLE1BQU0sQ0FBQyxjQUFjLEdBQUcsSUFBSSxDQUFDO1lBQy9CLENBQUM7UUFDRixDQUFDO0tBQ0Q7SUFsQlksbUJBQWEsZ0JBa0J6QixDQUFBO0FBQ0YsQ0FBQyxFQXJCUyxLQUFLLEtBQUwsS0FBSyxRQXFCZCIsInNvdXJjZXNDb250ZW50IjpbIm5hbWVzcGFjZSBUb29sc1xyXG57XHJcblx0ZXhwb3J0IGNsYXNzIE9yZGluYWxIZWxwZXJcclxuXHR7XHJcblx0XHRwdWJsaWMgc3RhdGljIHRvT3JkaW5hbChudW1iZXJUb0Zvcm1hdDogbnVtYmVyKTogc3RyaW5nIHtcclxuXHRcdFx0aWYgKG51bWJlclRvRm9ybWF0IDwgMCkgcmV0dXJuIG51bWJlclRvRm9ybWF0LnRvU3RyaW5nKCk7XHJcblx0XHRcdGNvbnN0IHJlbSA9IG51bWJlclRvRm9ybWF0ICUgMTAwO1xyXG5cdFx0XHRpZiAocmVtID49IDExICYmIHJlbSA8PSAxMykgcmV0dXJuIG51bWJlclRvRm9ybWF0ICsgXCJ0aFwiO1xyXG5cclxuXHRcdFx0c3dpdGNoIChudW1iZXJUb0Zvcm1hdCAlIDEwKSB7XHJcblx0XHRcdFx0Y2FzZSAxOlxyXG5cdFx0XHRcdFx0cmV0dXJuIG51bWJlclRvRm9ybWF0ICsgXCJzdFwiO1xyXG5cdFx0XHRcdGNhc2UgMjpcclxuXHRcdFx0XHRcdHJldHVybiBudW1iZXJUb0Zvcm1hdCArIFwibmRcIjtcclxuXHRcdFx0XHRjYXNlIDM6XHJcblx0XHRcdFx0XHRyZXR1cm4gbnVtYmVyVG9Gb3JtYXQgKyBcInJkXCI7XHJcblx0XHRcdFx0ZGVmYXVsdDpcclxuXHRcdFx0XHRcdHJldHVybiBudW1iZXJUb0Zvcm1hdCArIFwidGhcIjtcclxuXHRcdFx0fVxyXG5cdFx0fVxyXG5cdH1cclxufVxyXG4iXX0=
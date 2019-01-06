/// <reference path="./Algorithms/BubbleSort.ts"/>
function testSort() {
    let sort = new Algorithms.BubbleSort();
    let result = sort.execute([3, 2, 1]);
    console.log("result: " + result);
    return JSON.stringify(result); //.trim("]").trim("[");
}
//# sourceMappingURL=app.js.map
function solve(array) {
    var a = parseFloat(array[0]);
    var b = parseFloat(array[1]);
    var h = parseFloat(array[2]);
    var area = ((a + b) * h) / 2;
    return parseFloat(Math.round(area * 10000000) / 10000000).toFixed(7);
}
console.log(solve([5, 7, 12]));
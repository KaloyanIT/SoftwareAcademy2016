function solve(array) {
    var a = parseFloat(array[0]);
    var b = parseFloat(array[1]);
    var i;
    if (a > b) {
        i = b;
        b = a;
        a = i;
    }
    return a + " " + b;
}
console.log(solve([3, 5]));
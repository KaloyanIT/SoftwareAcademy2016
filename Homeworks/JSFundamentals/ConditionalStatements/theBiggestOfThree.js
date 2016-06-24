function solve(array) {
    var a = parseFloat(array[0]);
    var b = parseFloat(array[1]);
    var c = parseFloat(array[2]);
    if (a > b) {
        if (a > c) {
            return a;
        }
        return c;
    }
    if (c > b) {
        return c;
    }

    return b;
}

console.log(solve([5, 1, 2]));
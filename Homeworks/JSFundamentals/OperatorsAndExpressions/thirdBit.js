function solve(array) {
    var number = parseInt(array[0]);
    var mask = 1;
    mask <<= 3;

    var result = number & mask;
    if(result === 8) {
        return 1;
    } else {
        return 0;
    }
}
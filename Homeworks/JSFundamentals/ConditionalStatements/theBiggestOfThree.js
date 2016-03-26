

var numbers = [5, 1, 2];



function findBiggest(a, b, c) {
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

console.log(findBiggest(numbers[0], numbers[1], numbers[2]));
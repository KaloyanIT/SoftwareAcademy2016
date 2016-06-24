function sortNumbers(array) {
    var a = parseFloat(array[0]);
    var b = parseFloat(array[1]);
    var c = parseFloat(array[2]);
    if (a >= b) {
        if (a > c) {
            if (b = c) {
                return a + " " + b + ' ' + c;
            }
            else {
                return a + " " + c + ' ' + b;
            }
        } else {
            return c + " " + a + ' ' + b;
        }
    }
    if (b >= a) {
        if (b > c) {
            if (a > c) {
                return b + " " + a + ' ' + c;
            }
            else {
                return b + " " + c + ' ' + a;
            }
        } else {
            return c + " " + b + ' ' + a;
        }
    }
}
console.log(sortNumbers([-2, -2, 1]));


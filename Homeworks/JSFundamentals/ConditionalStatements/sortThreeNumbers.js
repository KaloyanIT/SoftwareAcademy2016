var numbers = [-2, -2, 1];

console.log(sortNumbers(numbers[0], numbers[1], numbers[2]));

function sortNumbers(a, b, c) {
    //if (a == b) {
    //    if (a > c) {
    //        return a + ", " + b + ', ' + c;
    //    }
    //}
    if (a >= b) {
        if (a > c) {
            if (b = c) {
                return a + ", " + b + ', ' + c;
            }
            else {
                return a + ", " + c + ', ' + b;
            }
        } else {
            return c + ", " + a + ', ' + b;
        }
    }
    if (b >= a) {
        if (b > c) {
            if (a > c) {
                return b + ", " + a + ', ' + c;
            }
            else {
                return b + ", " + c + ', ' + a;
            }
        } else {
            return c + ", " + b + ', ' + a;
        }
    }

}

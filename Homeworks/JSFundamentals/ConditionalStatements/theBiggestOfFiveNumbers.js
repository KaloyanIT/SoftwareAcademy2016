var numbers = [5, 2, 2, 4, 1];

console.log(findBiggest(numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]));

function findBiggest(a, b, c, d, e) {

    if (a >= b && a >= c && a >= d && a >= e)
    {
        return a;
    }
    else if (b >= a && b >= c && b >= d && b >= e)
    {
        return b;
    }
    else if (c >= a && c >= b && c >= d && c >= e)
    {
        return c;
    }
    else if (d >= a && d >= b && d >= c && d >= e)
    {
        return d;
    }
    else
    {
        return e;
    }
}
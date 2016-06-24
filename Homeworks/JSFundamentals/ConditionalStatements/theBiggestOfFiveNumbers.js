console.log(findBiggest([5, 2, 2, 4, 1]));
function findBiggest(array) {
    var a = parseFloat(array[0]);
    var b = parseFloat(array[1]);
    var c = parseFloat(array[2]);
    var d = parseFloat(array[3]);
    var e = parseFloat(array[4]);

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
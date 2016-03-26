var a = 5;
var b = 3;
var i;

if (a > b) {
    i = b;
    b = a;
    a = i;
}

console.log(a + ' ' + b);
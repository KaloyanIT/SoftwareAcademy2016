var a = 5;
var b = 2;
var c = 2;

var minusCount = 0;

if (a < 0) {
    minusCount++;
}
if (b < 0) {
    minusCount++;
}
if (c < 0) {
    minusCount++;
}

if (minusCount === 1 || minusCount === 3) {
    console.log('-');
} else {
    console.log('+');
}
var number = 5343;
var mask = 1;
mask <<= 3;

var result = number & mask;

var isTrue = result === 8;

console.log(isTrue);

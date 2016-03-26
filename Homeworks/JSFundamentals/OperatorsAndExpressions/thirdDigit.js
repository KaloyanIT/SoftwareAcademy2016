var number = 2440;

var thirdDigit = ( number / 100) % 10;
var digit = Math.floor(thirdDigit);
var isSeven = digit === 7;

console.log(digit);
console.log(isSeven);


var center = 0;
var x = -5;
var y = 0;
var radius = 5;


var isIn = Math.pow((x - center), 2)  + Math.pow((y - center), 2) <= Math.pow(radius, 2);

console.log(isIn);
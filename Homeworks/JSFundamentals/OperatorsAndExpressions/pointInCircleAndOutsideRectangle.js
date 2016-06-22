var pointX = 1;
var pointY = 4;
var centerX = 1;
var centerY = 1;
var radius = 3;


var insideCircle = Math.pow((pointX - centerX), 2) + Math.pow((pointY - centerY), 2) <= Math.pow(radius, 2);
console.log(insideCircle);

var insideRectangle = (pointX >= -1 && pointX <= 5) && (pointY <= 1 && pointY >= -1);
console.log(insideRectangle);

if (insideCircle == true && insideRectangle == false) {
    console.log(true);
}


function solve(array) {
    var x = parseFloat(array[0]);
    var y = parseFloat(array[1]);

}

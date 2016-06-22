// var center = 0;
// var x = -5;
// var y = 0;
// var radius = 5;
//
//
// var isIn = Math.pow((x - center), 2)  + Math.pow((y - center), 2) <= Math.pow(radius, 2);
//
// console.log(isIn);

function sovle(array) {
    var x = parseFloat(array[0]);
    var y = parseFloat(array[1]);
    var center = 0;
    var distance = Math.pow((x - center), 2)  + Math.pow((y - center), 2);
    var isIn = distance <= Math.pow(2, 2);
    return isIn + " " + parseFloat(Math.round(distance * 100) / 100).toFixed(2);
}
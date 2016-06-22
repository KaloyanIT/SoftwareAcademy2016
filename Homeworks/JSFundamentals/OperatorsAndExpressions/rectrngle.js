var array = [2.5, 3];
function solve(numbers) {
    var width = parseFloat(numbers[0]);
    var height = parseFloat(numbers[1]);
    var area = width * height;
    var perimeter = 2 * (width + height);
    console.log( parseFloat(Math.round(area * 100) / 100).toFixed(2) + " " + parseFloat(Math.round(perimeter * 100) / 100).toFixed(2));
}

console.log(solve(array));
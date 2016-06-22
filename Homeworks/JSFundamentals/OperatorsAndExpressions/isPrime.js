var number = 3;

for (var i = 2; i < number; i++) {
    if (number % i === 0) {
        var isPrime = false;
        break;
    }
    else {
        isPrime = true;
    }
}
console.log(isPrime);

function solve(array) {
    var number = parseInt(array[0]);
    if(number < 0) {
        return false;
    }
    for (var i = 2; i < number; i++) {
        if (number % i === 0) {
            return false;
        }
    }
    return true;
}
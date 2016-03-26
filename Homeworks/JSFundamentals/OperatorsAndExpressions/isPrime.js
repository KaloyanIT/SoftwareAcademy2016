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
function findPrimes(start, end) {
    if(start === undefined || end === undefined){
        throw new Error;
    }
    var from = parseInt(start);
    var to = parseInt(end);
    var array = [];
    for (var a = from; a <= to; a++) {
        if(a === 1 || a === 0){
            continue;
        }
        if(isPrime(a)){
            array.push(a);
        }
    }

    return array;

    function isPrime(number) {
        for (let i = 2; i < number; i++)
        {
            if (number % i == 0 && i != number) {
                return false;
            }
        }
        return true;
    }
}

//console.log(findPrimes(1, 5));

module.exports = findPrimes;
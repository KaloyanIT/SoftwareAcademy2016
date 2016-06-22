function solve(array) {
    var number = parseInt(array[0]);
    var thirdDigit = Math.floor((number / 100) % 10);
    if(thirdDigit === 7){
        return true;
    } else {
        return false + " " + thirdDigit;
    }
}
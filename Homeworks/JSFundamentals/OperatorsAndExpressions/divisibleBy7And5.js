
function oddOrEven(number) {
    if (number % 5 === 0 && number % 7 === 0) {
        return true;
    }
    else {
        return false;
    }
}
var number = 70;
var check = number % 5 === 0 && number % 7 === 0;
console.log(oddOrEven(35));
console.log(check);
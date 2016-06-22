var number = 9;

function solve(number){
    if(number % 2 == 0){
        return "even" + " " + number;
    }
    else {
        return "odd" + " " + number;
    }
}

console.log(isOddOrEven(number));
var number = 100;

function getLastDigit(number) {
    var lastDigit = parseInt( number % 10);
    switch(lastDigit){
        case 0 :
            return 'null';
        case 1 :
            return 'one';
        case 2 :
            return 'two';
        case 3 :
            return 'three';
        case 4 :
            return 'four';
        case 5 :
            return 'five';
        case 6 :
            return 'six';
        case 7 :
            return 'seven';
        case 8 :
            return 'eight';
        case 9 :
            return 'nine';
        default :
            return 'invalid Number';
    }
}

console.log(getLastDigit(number));
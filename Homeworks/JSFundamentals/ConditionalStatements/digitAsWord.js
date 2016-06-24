function solve(array) {
    var number = parseFloat(array[0]);
    var outputText;
    switch(number) {
        case 0 :
            return outputText = 'zero';
            break;
        case 1 :
            return outputText = 'one';
            break;
        case 2 :
            return outputText = 'two';
            break;
        case 3 :
            return outputText = 'three';
            break;
        case 4 :
            return outputText = 'four';
            break;
        case 5 :
            return outputText = 'five';
            break;
        case 6 :
            return outputText = 'six';
            break;
        case 7 :
            return outputText = 'seven';
            break;
        case 8 :
            return outputText = 'eight';
            break;
        case 9 :
            return outputText = 'nine';
            break;
        default :
            return outputText = 'not a digit';
            break;
    }
}


console.log(solve([2]));

console.log(solve([2]));
function solve(array) {
    var number = parseFloat(array[0]);
    var outputText = '';
    if(number < 21) {
        switch (number) {
            case 0 :
                return outputText = 'Zero';
                break;
            case 1 :
                return outputText = 'One';
                break;
            case 2 :
                return outputText = 'Two';
                break;
            case 3 :
                return outputText = 'Three';
                break;
            case 4 :
                return outputText = 'Four';
                break;
            case 5 :
                return outputText = 'Five';
                break;
            case 6 :
                return outputText = 'Six';
                break;
            case 7 :
                return outputText = 'Seven';
                break;
            case 8 :
                return outputText = 'Eight';
                break;
            case 9 :
                return outputText = 'Nine';
                break;
            case 10 :
                return outputText = 'Ten';
                break;
            case 11 :
                return outputText = 'Eleven';
                break;
            case 12 :
                return outputText = 'Twelve';
                break;
            case 13 :
                return outputText = 'Thirteen';
                break;
            case 14 :
                return outputText = 'Fourteen';
                break;
            case 15 :
                return outputText = 'Fifteen';
                break;
            case 16 :
                return outputText = 'Sixteen';
                break;
            case 17 :
                return outputText = 'Seventeen';
                break;
            case 18 :
                return outputText = 'Eighteen';
                break;
            case 19 :
                return outputText = 'Nineteen';
                break;
            case 20 :
                return outputText = 'Twelve';
                break;
            default :
                return outputText = 'Not a number';
                break;
        }
    }

}


//TODO: Da go dovursha
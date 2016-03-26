var expression = '((a + b) + c)';

function checkBrackets(expression) {
    var leftBracket = 0,
        rightBracket = 0;


    for (var i = 0; i < expression.length; i++) {
        if (expression[i] === '(') {
            leftBracket += 1;
        }
        if (expression[i] === ')') {
            rightBracket += 1;
        }
    }

    if(leftBracket === rightBracket) {
        return true;
    } else {
        return false;
    }
}

console.log(checkBrackets(expression));
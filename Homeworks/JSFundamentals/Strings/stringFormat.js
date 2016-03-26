var text = '{0}, {1}, {0} text {4} {2}';
//var re = new RegExp();

function stringFormat(input) {
    var newString = text;
    while(checkBrackets(newString)){
        for (var i = 0; i < arguments.length; i++) {
            var obj = arguments[i];
            var replaced = '{' + i + '}';
            //re = new RegExp(replaced, 'g');
            //re = re.toString().replace(/\\\//g, '');
            //console.log(re);
            newString = newString.replace(replaced, obj);
        }
    }
    return newString;
}

function checkBrackets(text){
    var isTrue = false;
    for (var i = 0; i < text.length; i++) {
        if (text[i] === '{') {
            isTrue = true;
        }
    }
    if (isTrue === false) {
        return false;
    } else {
        return true;
    }
}

console.log(stringFormat(5, 'Gosho', 'Ivan', 18, 43, 28));

var text = "The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking al the day. We will move out of it in 5 days.";

var subString = 'in';

function findSubString(text, subString) {
    var count = 0;
    for (var i = 0; i < text.length - 1; i++) {
        if(text[i] + text[i + 1] === subString) {
            count += 1;
        }
    }
    return count;
}

console.log(findSubString(text, subString));
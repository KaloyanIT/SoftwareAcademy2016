var text = 'abba mama kaak lammal';

var words = text.match(/\b\w+\b/g);

function checkPalindrome(word) {
    return word == word.split('').reverse().join('');
}

for (var i = 0; i < words.length; i++) {

    if (checkPalindrome(words[i]) === true) {
        console.log(words[i]);
    }

}
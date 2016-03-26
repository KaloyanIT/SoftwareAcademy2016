var number = 123.45;





function reverseNumber(number) {
    var n = number.toString();
    var reverseNumber = '';
    for (var i = n.length - 1; i >= 0; i--) {
        reverseNumber += n[i];
    }
    return reverseNumber;
}

console.log(reverseNumber(number));

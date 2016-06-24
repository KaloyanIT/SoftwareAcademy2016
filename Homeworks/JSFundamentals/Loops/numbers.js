function solve(array) {
    var number = array[0];
    var text = "";
    for (var i = 1; i <= number; i++) {
        text += i.toString() + " ";
    }
    return text;
}
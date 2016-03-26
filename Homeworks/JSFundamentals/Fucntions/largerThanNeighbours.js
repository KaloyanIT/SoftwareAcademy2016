var array = [2, 5, 3, 8, 7, 6, 9],
    position = 2;

function checkElementAtPosition(array, position) {
    var i;
    if (position < 1 || position > array.length - 1) {
        return 'This element have not two neighbours';
    } else {
        i = position;
            if (array[i - 1] < array[i] && array[i] > array[i + 1]) {
                return true;
            } else {
                return false;
            }
    }
}

console.log(checkElementAtPosition(array, position));
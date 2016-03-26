var array = [2, 1, 3, 6, 9, 11, 15];


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

function firstLargerThanNeighbours(array) {
    for (var i = 1; i < array.length - 1; i++) {
        if (checkElementAtPosition(array, i) == true) {
            return i;
        }
    }
    return -1;
}


console.log(firstLargerThanNeighbours(array));
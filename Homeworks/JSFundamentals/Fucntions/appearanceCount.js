var array = [2, 3, 2, 2, 2, 2, 2, 2, 3, 4, 4, 5, 6, 7, 8, 9],
    givenNumber = 2;

function countNumberInArr(array, number) {
    var count = 0;

    for (var i = 0; i < array.length; i++) {
        if (array[i] == number) {
            count += 1;
        }
    }
    return count;
}

console.log(countNumberInArr(array, givenNumber));


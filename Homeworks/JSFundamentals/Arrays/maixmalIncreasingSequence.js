var array = [3, 2, 3, 4, 2, 2, 4],
    currentSequence = 1,
    sequence = 0,
    startIndex,
    endIndex;

for (var i = 0; i < array.length - 1; i++) {
    if (array[i] < array[i + 1]) {
        currentSequence += 1;
        if (currentSequence > sequence) {
            sequence = currentSequence;
            endIndex = i + 1;
        }
    } else {
        currentSequence = 0;
    }
}
startIndex = endIndex - sequence;

for (var a = startIndex; a <= endIndex; a++) {
    console.log(array[a]);

}
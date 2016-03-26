var array = [2, 1, 1, 2, 3, 3, 2, 2, 2, 2, 1];



    var startIndex = 0,
        currentSeqLength = 1,
        seqLength = 1,
        endIndex = 0;
    for (var i = 0; i < array.length - 1; i++) {
        if (array[i] === array[i + 1]) {
            currentSeqLength += 1;
            if (seqLength < currentSeqLength) {
                seqLength = currentSeqLength;
                endIndex = i + 1;
            }
        } else {
            currentSeqLength = 0;

        }
    }
     startIndex = endIndex - seqLength;
    for (var a = startIndex; a <= endIndex; a++) {
        console.log(array[a]);

    }





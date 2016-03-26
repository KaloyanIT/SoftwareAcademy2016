var array = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    number,
    currentFrequency = 0,
    frequency = 0;

for (var i = 0; i < array.length; i++) {
    for (var a = 0; a < array.length; a++) {
        if (array[i] == array[a]) {
            currentFrequency += 1;
            if (currentFrequency > frequency) {
                frequency = currentFrequency;
                currentFrequency = 0;
                number = array[a];
            }
        }
    }
    currentFrequency = 0;
}


console.log(frequency);
console.log(number);

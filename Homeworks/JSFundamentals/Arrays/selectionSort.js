var array = [2, 8, 1, 3, 4, 7, 6],
    temp;


for (var i = 0; i < array.length; i++) {
    for (var a = i; a < array.length; a++) {
        if (array[i] > array[a]) {
            temp = array[i];
            array[i] = array[a];
            array[a] = temp;
        }
    }
}

for (var o = 0; o < array.length; o++) {
    console.log(array[o]);

}
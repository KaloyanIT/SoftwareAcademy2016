var max = 99;

for (var i = 1; i < max; i++) {
    if (i % 3 === 0 && i % 7 === 0) {
        continue;
    } else {
        console.log(i);
    }
}

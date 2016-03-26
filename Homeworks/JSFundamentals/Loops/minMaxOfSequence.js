var numbers = [2, 8, 32, 3, 18, 6, 15];

numbers.sort(function(a, b){return a-b});

console.log('min: ' + numbers[0] + ' max: ' + numbers[numbers.length - 1]);


//Way with Loop

function findMin(numbers) {
    var current = 0;
    var min = 100;
    for (var i = 0; i < numbers.length; i++) {
        current = numbers[i];
        if (current < min) {
            min = current;
        }
    }
    return 'Min: ' + min;

}



function findMax(numbers) {
    var current = 0;
    var max = 0;
    for (var i = 0; i < numbers.length; i++) {
        current = numbers[i];
        if (current > max) {
            max = current;
        }
    }
    return 'Max: ' + max;
}

console.log(findMin(numbers));
console.log(findMax(numbers));
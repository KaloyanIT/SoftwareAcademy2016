var numbers = [2, 8, 32, 3, 18, 6, 15];
function solve(array){
    var sum,
        min = 200,
        max = -200,
        avg,
        currentMin,
        currentMax;

    for(a = 0; a < array.length; a++){
        sum += array[a];
    }

    for(i = 0; i < array.length; a++){
        currentMax = currentMin = array[i];
        if(currentMax > max){
            max = currentMax;
        }
        if(currentMin < min){
            min = currentMin;
        }
    }
    avg = (sum / array.length);
    console.log("min=" + min);
    console.log("max=" + max);
    console.log("sum=" + sum);
    console.log("avg=" + sum);
    return 0;
}

console.log(solve(numbers));


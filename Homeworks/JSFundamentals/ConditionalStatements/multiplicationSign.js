function solve(array) {
    var a = parseFloat(array[0]);
    var b = parseFloat(array[1]);
    var c = parseFloat(array[2]);
    if(a == 0 || b == 0 || c == 0){
        return 0;
    }else{
        var minusCount = 0;

        if (a < 0) {
            minusCount++;
        }
        if (b < 0) {
            minusCount++;
        }
        if (c < 0) {
            minusCount++;
        }

        if (minusCount === 1 || minusCount === 3) {
            return "-"
        } else {
            return "+"
        }
    }
}
console.log(solve([5, 2, 2]));
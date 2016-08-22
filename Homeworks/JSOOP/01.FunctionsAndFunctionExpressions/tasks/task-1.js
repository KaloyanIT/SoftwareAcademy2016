function sum(array) {
    if(array.length === 0) {
        return null;
    }
    var sum = 0;
    for(let a = 0; a < array.length; a++){
        if(array[a] === undefined) {
            throw new Error("Parameter is not passed");
        }
        if(isNaN(array[a])){
            throw new Error("Not a number");
        }
        sum += parseInt(array[a]);
    }
    return sum;
}

//console.log(sum([1, 2, 3]));

module.exports = sum;



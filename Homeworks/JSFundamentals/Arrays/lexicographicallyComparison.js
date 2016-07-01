// Array.prototype.compareLexic = function (array) {
//     for (var i = 0; i < Math.min(this.length, array.length); i++) {
//         if (this[i] !== array[i]) {
//             return this[i] < array[i] ? ">" : "<";
//         }
//     }
//
//     if (this.length !== array.length) {
//         return this.length < array.length ? ">" : "<";
//     }
//
//     return "=";
//
// };

function solve(array) {
    var array1 = array[0];
    var array2 = array[1];

    for (var i = 0; i < Math.min(array1.length, array2.length); i++) {
        if (array1[i] !== array2[i]) {
            return array1[i] < array2[i] ? "<" : ">";
        }
    }

    if (array1.length !== array2.length) {
        return array1.length < array2.length ? "<" : ">";
    }

    return "=";
}

console.log(solve(['food', 'food']));
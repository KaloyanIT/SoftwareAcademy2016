Array.prototype.compareLexic = function (array) {
    for (var i = 0; i < Math.min(this.length, array.length); i++) {
        if (this[i] !== array[i]) {
            return this[i] < array[i] ? -1 : 1;
        }
    }

    if (this.length !== array.length) {
        return this.length < array.length ? -1 : 1;
    }

    return 0;

};

console.log(['a', 'b', 'c'].compareLexic(['a', 'b', 'c']));
console.log(['a', 'b', 'c'].compareLexic(['a', 'c', 'b']));
console.log(['a', 'c', 'b'].compareLexic(['a', 'b', 'c']));

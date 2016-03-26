var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];

Array.prototype.remove = function() {
    for (var i = 0; i < this.length; i++) {
        if (this[i] === arguments[0]) {
            this.splice(i, 1);
            i -= 1;
        }
    }
};

arr.remove(1);

console.log(arr);

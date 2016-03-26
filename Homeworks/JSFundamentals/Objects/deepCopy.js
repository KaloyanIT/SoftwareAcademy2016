var obj1 = {
    name: 'pesho',
    age: 18,
};

function clone(obj) {
    if (!(typeof obj == 'object')) {
        return obj;
    }
    var cloned = {};
    for (var prop in obj) {
        cloned[prop] = clone(obj[prop]);
    }
    return cloned;
}

console.log(clone(obj1));
var obj = {
    name: 'ivan',
    surname: 'peshov',
    age: '13'
};
console.log(hasProperty(obj, 'name'));


function hasProperty(obj, property) {
    return obj.hasOwnProperty(property);
}
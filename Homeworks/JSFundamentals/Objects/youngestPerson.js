var people = [
    { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
    { firstname : 'Bay', lastname: 'Ivan', age: 81},
    { firstname : 'gay', lastname: 'Iban', age: 11},
];

function findYoungest(people) {
    var currentAge,
        youngestAge = 100,
        personNumber;
    for (var i = 0; i < people.length; i++) {
        currentAge = people[i].age;
        if (currentAge < youngestAge) {
            youngestAge =currentAge;
            personNumber = i;
        }
    }
    return people[personNumber].firstname + ' ' + people[personNumber].lastname;
}

console.log(findYoungest(people));
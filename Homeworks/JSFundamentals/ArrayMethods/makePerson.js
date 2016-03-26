var persons = [
    new Person('Kim', 'Valencia', 25, 'male'),
    new Person('Charlotte', 'Le Bonne', 29, 'female'),
    new Person('James', 'Tomkins', 15, 'male'),
    new Person('Helen', 'Owen', 17, 'female'),
    new Person('Kevin', 'Nolan', 32, 'male'),
    new Person('Audrey', 'Tautou', 39, 'female'),
    new Person('Jerard', 'Pique', 21, 'male'),
    new Person('Penelope', 'Cruz', 41, 'female'),
    new Person('Jean', 'Dujardin', 42, 'male'),
    new Person('Keira', 'Knightley', 29, 'female')
];


persons.forEach(function (item, index) {
    console.log('Index' + index + ' ' + JSON.stringify(item));
});

function Person(firstName, lastName, age, gender) {

    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.gender = gender;
}

//Problem2
var isUnder18 = false;
persons.forEach(function(item) {
    if (item.age < 18) {
        isUnder18 = true;
    }
});

console.log("Is there someone under 18" + isUnder18);

//Problem3

var newArray = persons.filter(function() {
    return age < 18;
});
 console.log(newArray.length);

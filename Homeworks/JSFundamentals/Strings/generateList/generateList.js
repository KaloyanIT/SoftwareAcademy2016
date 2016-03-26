(function(){

    var people = [
        {name: 'Peter', age: 14},
        {name: 'Peter', age: 14},
        {name: 'Peter', age: 14},
        {name: 'Peter', age: 14}
    ];


    var beginString = '<ul>',
        endString = '</ul>',
        fullString = '',
        li = '',
        strong = '',
        span = '';

    function makeList(name, age) {
        li = '';
        li += '<li>';
        li += addStrong(name).toString();
        li += ' ';
        li += addSpan(age).toString();
        li += '</li>';
        return li;
    }

    function concatLi(li) {
        fullString += li;
    }

    function addStrong(name) {
        strong = '';
        strong += '<strong>';
        strong += name.toString();
        strong += '</strong>';
        return strong;
    }

    function addSpan(age) {
        span = '';
        span += '<span>';
        span += age.toString();
        span += '</span>';
        return span;
    }

    function printFullString() {
        return beginString + fullString + endString;
    }


    for (var i = 0; i < people.length; i++) {
        concatLi(makeList(people[i].name, people[i].age));
    }

    console.log(printFullString());




}());





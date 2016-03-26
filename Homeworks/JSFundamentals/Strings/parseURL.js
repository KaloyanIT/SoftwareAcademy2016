var url = "http://telerikacademy.com/Courses/Courses/Details/239";

var pattern = /(\w+):\/\/(\w+.\w+)\/(.*)/g;

var match = pattern.exec(url);

var object = {
    '[protocol]': match[1],
    '[server]': match[2],
    '[resources]': match[3]
};

console.log(object);
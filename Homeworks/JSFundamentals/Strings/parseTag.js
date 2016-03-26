var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";


function parseTags(text) {
    var upPattern = /(<upcase>)(.*?)(<\/upcase>)/g,
        lowPattern = /(<lowcase>)(.*?)(<\/lowcase>)/g,
        mixPattern = /(<mixcase>)(.*?)(<\/mixcase>)/g,
        upMatch = upPattern.exec(text),
        lowMatch = lowPattern.exec(text),
        mixMatch = mixPattern.exec(text);


}

console.log(parseTags(text));
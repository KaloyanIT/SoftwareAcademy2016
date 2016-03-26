var text = 'pesho e golyam pedal i lapa mn pishki';

function replaceWhiteSpace(text) {
    var k = text.replace(/ /g, '&nbsp');
    return k;

}

console.log(replaceWhiteSpace(text));
var text = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

//var replaced = text.replace(/(<a href="[a-zA-Z.\/:\/]+">)/g, '[URL=…]'),
//    closedTags = text.replace(/<\/a>/g, '');


var openTag = text.replace(/(<a href=")/g, '[URL='),
    closeOpenTag = openTag.replace(/">/g, ']'),
    closeTag = closeOpenTag.replace(/<\/a>/g, '[/URL]');


console.log(closeTag);
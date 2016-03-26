var text = "<html<head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body>";

var replaced = text.replace(/<[^>]*>/g, ' ');

console.log(replaced);
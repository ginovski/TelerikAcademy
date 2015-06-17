'use strict';

var html = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';

console.log(extractContentFromHtml(html));

function extractContentFromHtml(html){
    var stringWithoutTagNames,
        textInHtml;

    stringWithoutTagNames = html.match(/>([^<]*)</g).join('');
    textInHtml = stringWithoutTagNames.replace(/[<>]/g, '');

    return textInHtml;
}

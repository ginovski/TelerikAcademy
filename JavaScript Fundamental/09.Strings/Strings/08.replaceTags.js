//08.Write a JavaScript function that replaces in a HTML document
//given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]
'use strict';

var html = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

console.log(replaceTags(html));

function replaceTags(html) {
    var tagPattern = /<a href="([a-z:\/.]+)">/g,
        replaced;

    replaced = html.replace(tagPattern, function($tag, $href){
        return '[URL=' + $href + ']';
    }).replace(/<\/a>/g, '[/URL]');

    return replaced;
}

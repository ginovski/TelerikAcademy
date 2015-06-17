//02.Write a function that puts the value of an object into the content/attributes of HTML tags.
//Add the function to the String.prototype
'use strict';

String.prototype.bind = function(obj) {
    var prop,
        reContent,
        reHref,
        reClass,
        result = this;

    for (prop in obj) {
            reContent = new RegExp('(<.*data-bind-content="' + prop + '".*>)(.*)(<.*>)', 'gi');
            reHref = new RegExp('(<.*data-bind-href="' + prop + '")', 'gi');
            reClass = new RegExp('(data-bind-class="' + prop + '")', 'gi');

        result = result.replace(reContent, function(none, opening, content, closing) {
            content = obj[prop];
            return opening + content + closing;
        })
            .replace(reHref, function(none, content) {
                return content + ' href="' + obj[prop] + '"';
            })
            .replace(reClass,  function(none, content) {
                return content + ' class="' + obj[prop] + '"';
            });
    }
    return result;
};

var str = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></a>',
result = str.bind({
    name: 'Gosho',
    link: 'http://google.com'
});
console.log(result);

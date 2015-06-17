//11.Write a function that formats a string using placeholders.
//The function should work with up to 30 placeholders and all types.
'use strict';

var str = stringFormat('Hello {0}!', 'Peter');

console.log(str);

function stringFormat(format){
    var args = Array.prototype.slice.call(arguments),
        placeHolder,
        format;
        format = format.replace(/\{([0-90-9])\}/g, function(placeholder, param){
            return args[(param | 0) + 1];
        });
    
    return format;
}

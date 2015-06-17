//01.Write a JavaScript function that reverses a string and returns it.
'use strict';

var str = 'sample';
console.log(reverseString(str));

function reverseString(str){
    var reversed = '',
        i, len;

    for (var len = str.length, i = len - 1; i >= 0; i-=1) {
        reversed += str[i];
    }

    return reversed;
}

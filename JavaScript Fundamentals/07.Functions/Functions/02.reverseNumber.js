//02.Write a function that reverses the digits of given decimal number.
'use strict';

var input = 123.45;
console.log(reverseNumber(input));

function reverseNumber(number) {
    var numberAsString = number.toString(),
        reversed = '';

    for (var length = numberAsString.length - 1, i = length; i >= 0; i-=1) {
        reversed += numberAsString[i];
    } 
    
    return reversed - 0;
}

//04.Write an expression that checks for given integer if its third digit (right-to-left) is 7.
'use strict';

var number = 701;
var isThirdDigit7 = (Math.floor(number / 100) % 10) === 7;

console.log('Third digit of ' + number + ' is 7 ---> ' + isThirdDigit7);
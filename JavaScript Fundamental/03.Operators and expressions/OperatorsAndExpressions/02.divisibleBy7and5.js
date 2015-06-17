//02.Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
'use strict';

var number = 35;
var divisibleBySevenAndFive = number % 7 === 0 && number % 5 === 0;

console.log('Number ' + number + ' is divisible by seven and five in the same time ---> ' + divisibleBySevenAndFive);

//05.Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.
'use strict';

var number = 8;
var position = 3;
var mask = 1 << position ;
var numAndMask = number & mask;
var bit = numAndMask >> position;

console.log('Third bit of ' + number + ' is ' + bit );

//07.Write an expression that checks if given positive integer number n (n ? 100) is prime.
'use strict';

var number = 37;
var isPrime = ((number % 2 > 0) && (number % 3 > 0) && (number % 5 > 0) && (number % 7 > 0))
    || ((number === 2) || (number === 3) || (number === 5) || (number === 7));

console.log('Number ' + number + ' is prime ---> ' + isPrime);

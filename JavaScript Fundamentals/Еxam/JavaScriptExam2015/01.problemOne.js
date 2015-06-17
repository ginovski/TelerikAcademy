'use strict';

function solve(params){
    var numbers = params[0].split(' ').map(Number);
    var counter = 0;
    var maxCounter = 0;
    for (var i = 0, len = numbers.length; i < len; i += 1) {
        if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1] && numbers[i + 1] >= 0 && numbers[i - 1] >= 0) {
            numbers[i] = -1;
        }
    }

    numbers[0] = -1;
    numbers[numbers.length - 1] = -1;

    for (var j = 0; j < numbers.length; j += 1) {
        if (numbers[j] !== -1) {
            counter++;
        }
        else{
            counter++;
            if (counter > maxCounter) {
               maxCounter = counter;
                counter = 0;
            }
        }
    }
    
    console.log(maxCounter);
}

var args = ['5 1 7 4 8'];
var args2 = ['5 1 7 6 3 6 4 2 3 8'];
var args3 = ['10 1 2 3 4 5 4 3 2 1 10'];
solve(args);
console.log('--------------------------');
solve(args2);
console.log('--------------------------');
solve(args3);

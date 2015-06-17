//03.Write a script that finds the max and min number from a sequence of numbers.
'use strict';

var numbers = [1, 5, 2, 8, 4, 7],
    min = numbers[0],
    max = numbers[0],
    length = numbers.length,
    i;

for (i = 1; i < length; i += 1) {
    if (numbers[i] > max) {
        max = numbers[i];
    }
    if (numbers[i] < min) {
        min = numbers[i];
    }
}

console.log(numbers);
console.log('Min: ' + min);
console.log('Max: ' + max);

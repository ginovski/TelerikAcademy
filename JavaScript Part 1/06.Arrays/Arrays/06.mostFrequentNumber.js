//06.Write a script that finds the most frequent number in an array
'use strict';

var numbers = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    count = 0,
    maxCount = 0,
    number = 0,
    i,
    j,
    length = numbers.length;

for (i = 0; i < length; i += 1) {
    for (j = 0; j < length; j += 1) {
        if (numbers[i] === numbers[j]) {
            count++;
        }
    }
    if (count > maxCount) {
        maxCount = count;
        number = numbers[i];
    }
    count = 0;
} 

console.log(number + '(' + maxCount + ' times)');

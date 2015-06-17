//03.Write a script that finds the maximal sequence of equal elements in an array.
'use strict';

var numbers = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
    sequenceLength = 1,
    maxSequenceLength = 0,
    maxSequenceIndex = 0,
    i, length;

for (i = 0, length = numbers.length; i < length; i += 1) {
    if (numbers[i] === numbers[i + 1]) {
        sequenceLength++;
    }
    else{
        if (sequenceLength > maxSequenceLength) {
            maxSequenceLength = sequenceLength;
            maxSequenceIndex = i - sequenceLength + 1;
        }
        sequenceLength = 1;
    }
}

console.log(numbers.slice(maxSequenceIndex, maxSequenceIndex + maxSequenceLength));


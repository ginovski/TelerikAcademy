//04.Write a script that finds the maximal increasing sequence in an array.
'use strict';

var numbers = [3, 2, 3, 4, 2, 2, 4],
    sequenceLength = 1,
    maxSequenceLength = 0,
    maxSequenceIndex = 0,
    i, length;

for (i = 0, length = numbers.length; i < length; i += 1) {
    if (numbers[i] + 1 === numbers[i + 1]) {
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



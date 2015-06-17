//07.Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
'use strict';

var numbers = [1, 3, 4, 6, 8, 9, 11],
    keyToBeFound = 4,
    minIndex = 0,
    middleIndex = 0,
    maxIndex = numbers.length - 1,
    indexFound = -1;

numbers.sort(function(a,b){
    return a - b;
});

while (maxIndex >= minIndex)
{
    middleIndex = minIndex + ((maxIndex - minIndex) / 2);
    if(numbers[middleIndex] === keyToBeFound) {
        indexFound = middleIndex;
        break;
    }
    else if (numbers[middleIndex] < keyToBeFound)
        minIndex = middleIndex + 1;
    else
        maxIndex = middleIndex - 1;
}

console.log(indexFound);
    


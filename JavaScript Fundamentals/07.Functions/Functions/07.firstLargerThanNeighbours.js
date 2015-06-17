//07.Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
//Use the function from the previous exercise.
'use strict';

var numbers = [1, 2, 3, 4, 6, 5, 7, 8, 9];
console.log(firstLargerThanNeighbours(numbers));

function firstLargerThanNeighbours(numbers) {
    var i, len;
    for (i = 0, len = numbers.length; i < len; i += 1) {
        if (largerThanNeighbours(numbers, i)) {
            return i;
        }
    }

    return -1;
}

function largerThanNeighbours(numbers, index){
    if (index < 1 || index >= numbers.length - 1) {
        return false;
    }

    return numbers[index] > numbers[index + 1] && numbers[index] > numbers[index - 1];
}
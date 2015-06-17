//06.Write a function that checks if the element at given position in given array of integers is bigger than
//its two neighbours (when such exist).
'use strict';

var numbers = [1, 2, 3, 4, 6, 5, 7, 8, 9],
    index = 4;

console.log('Element is larger than its neighbours ---> ' +largerThanNeighbours(numbers, index));

function largerThanNeighbours(numbers, index){
    if (index < 1 || index >= numbers.length - 1) {
        return 'There is no 2 neighbours';
    }

    return numbers[index] > numbers[index + 1] && numbers[index] > numbers[index - 1];
}

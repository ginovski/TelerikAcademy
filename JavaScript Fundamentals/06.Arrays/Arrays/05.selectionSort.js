//05.Sorting an array means to arrange its elements in increasing order.
//Write a script to sort an array.
//Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest,
// move it at the second position, etc.
'use strict';

var numbers = [4, 2, 3, 7, 19, 5, 8],
    i,
    j,
    length = numbers.length,
    minElementIndex,
    elementToSwap;

for (j = 0; j < length - 1; j++) {
    minElementIndex = j;
    for ( i = j+1; i < length; i++) {
        if (numbers[i] < numbers[minElementIndex]) {
            minElementIndex = i;
        }
    }

    if(minElementIndex != j) {
        elementToSwap = numbers[j];
        numbers[j] = numbers[minElementIndex];
        numbers[minElementIndex] = elementToSwap;
    }
}

console.log(numbers);

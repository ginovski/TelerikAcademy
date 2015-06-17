//05.Write a function that counts how many times given number appears in given array.
//Write a test function to check if the function is working correctly.
'use strict';

checkCountAppearance();

function countAppearance(arr, item){
    var counter = 0,
        i, len;
    for (i = 0, len = arr.length; i < len; i += 1) {
        if (arr[i] === item) {
            counter++;
        }
    }

    return counter;
}

function checkCountAppearance(){
    var numbers = [1, 2, 1, 2, 3, 4, 5, 6, 1, 7, 8],
        numberToCount = 1;

    console.log(countAppearance(numbers, numberToCount));
}

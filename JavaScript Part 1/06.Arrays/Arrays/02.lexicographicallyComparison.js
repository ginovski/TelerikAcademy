//02.Write a script that compares two char arrays lexicographically (letter by letter).
'use strict';

var firstLetters = ['a', 'b', 'c'],
    secondLetters = ['a', 'c', 'b'],
    i,
    length,
    areEqual = true;

if (firstLetters.length !== secondLetters.length) {
    console.log('Arrays are equal ---->' + !areEqual);
} 
else{
    for (i = 0, length = firstLetters.length; i < length; i += 1) {
        if (firstLetters[i] !== secondLetters[i]) {
            areEqual = false;
        }
    }
    
    console.log('Arrays are equal --->' + areEqual);
}

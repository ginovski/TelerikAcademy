//03.Write a script that finds the biggest of three numbers.
//Use nested if statements.
'use strict';

var a = 5,
    b = 2,
    c = 2;

if (a > b) {
    if (a > c) {
        console.log(a);
    }
    else {
        console.log(c);
    }
} 
else if (b > a) {
    if (b > c) {
        console.log(b);
    }
    else{
       console.log(c);
    }
} 
else if (c > a) {
    if (c > b) {
        console.log(c);
    }
    else {
        console.log(b);
    }
} 

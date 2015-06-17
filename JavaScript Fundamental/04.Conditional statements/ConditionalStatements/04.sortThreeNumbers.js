//04.Sort 3 real values in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.
'use strict';

var a = 5,
    b = 1,
    c = 2;

if (a > b) {
    if (a > c) {
        if (b > c) {
            console.log(a, b, c);
        }
        else {
            console.log(a, c, b);
        }
    }
}
else if (b > a) {
    if (b > c) {
        if (a > c) {
            console.log(b, a, c);
        }
        else {
            console.log(b, c, a);
        }
    }
}
else if (c > a) {
    if (c > b) {
        if (a > b) {
            console.log(c, a, b);
        }
        else {
            console.log(c, b, a);
        }
    }
}
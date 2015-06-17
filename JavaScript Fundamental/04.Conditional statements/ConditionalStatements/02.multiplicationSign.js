//02.Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
'use strict';

var a = -1,
    b = -4,
    c = -3;

if (!a || !b || !c) {
    console.log(0);
} 
else if (a < 0 && b < 0 && c < 0) {
    console.log('-');
}
else if ((a < 0 && b < 0) || (a < 0 && c < 0) || (b < 0 && c < 0))  {
    console.log('+');
}
else if (a < 0 || b < 0 || c < 0) {
    console.log('-');
}
else {
    console.log('+');
}
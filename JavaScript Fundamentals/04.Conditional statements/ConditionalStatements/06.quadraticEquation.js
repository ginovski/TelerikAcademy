//06.Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Calculates and prints its real roots.
//Note: Quadratic equations may have 0, 1 or 2 real roots.
'use strict';

var a = 2,
    b = 5,
    c = -3,
    x1,x2, D;

D = (b * b) - (4 * a * c);
if (D < 0) {
    console.log('no real roots');
}
else if (D === 0) {
    x1 = -b / (2 * a);
    console.log('x1=x2=' + x1);
}
else{
    x1 = (-b - Math.sqrt(D)) / (2 * a);
    x2 = (-b + Math.sqrt(D)) / (2 * a);
    console.log('x1=' + x1 + '; ' + 'x2=' + x2);
}
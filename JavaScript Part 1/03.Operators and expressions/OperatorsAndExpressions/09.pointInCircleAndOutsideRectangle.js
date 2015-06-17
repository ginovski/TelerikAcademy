//09.Write an expression that checks for given point P(x, y)
// if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
'use strict';


var pointX = 1,
    pointY = 2;

var circleX = 1,
    circleY = 1,
    circleRadius = 3,
    rectTop = 1,
    rectLeft = -1,
    rectWidth = 6,
    rectHeight = 2;

var inCircle = ((pointX - circleX) * (pointX - circleX)) +  ((pointY - circleY) * (pointY - circleY)) < circleRadius * circleRadius;
var outSideRect = (pointX > (rectWidth - rectLeft)) || (pointX < rectLeft) || (pointY > rectTop) || (pointY < (rectTop - rectHeight));

console.log('Point is in circle and outside rectangle ---> ' + ((inCircle && outSideRect) ? 'yes' : 'no'));
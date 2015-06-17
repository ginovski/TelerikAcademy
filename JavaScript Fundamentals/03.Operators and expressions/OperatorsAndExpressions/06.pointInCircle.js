//06.Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius
'use strict';

var pointX  = 0,
    pointY = 1;

var radius = 5;
var pointInCircle = (pointX * pointX) + (pointY * pointY) < radius * radius;

console.log('Point (' + pointX + ', ' + pointY + ') is in the circle ---> ' + pointInCircle);

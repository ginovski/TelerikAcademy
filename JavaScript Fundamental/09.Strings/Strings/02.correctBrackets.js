//02.Write a JavaScript function to check if in a given expression the brackets are put correctly.
'use strict';

var expr = "((a+b))",
    leftBracketsCount = checkBrackets(expr, "("),
    rightBracketsCount = checkBrackets(expr, ")");

if (leftBracketsCount===rightBracketsCount) {
    console.log("The brackets are placed right " +  " --- " + expr);
}
else {
    console.log("The brackets are placed wrong " +  " --- " + expr);
}

function checkBrackets(expr,bracket){
    var count = 0;
    for (var i = 0; i <expr.length; i++) {
        if (expr[i] === bracket) {
            count++;
        }
    }
    return count;
}

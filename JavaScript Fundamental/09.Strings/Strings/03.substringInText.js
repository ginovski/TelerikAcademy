//03.Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
'use strict';

var text = "The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.",
    subStr = 'in';

console.log(countSubstringInText(text, subStr));

function countSubstringInText(text, subStr) {
    var counter = 0,
        index;

    text = text.toLowerCase();
    subStr = subStr.toLowerCase();

    index = text.indexOf(subStr);
    while(index !== -1) {
        counter++;
        index = text.indexOf(subStr, index + 1);
    }

    return counter;
}

//05.Write a function that replaces non breaking white-spaces in a text with &nbsp;
'use strict';

var text = 'The text is as follows: We are living in an yellow submarine.';

var replaced = replaceSpaces(text);
console.log(replaced);

function replaceSpaces(text){
    return text.replace(/ /g, '&nbsp');
}

//04.You are given a text. Write a function that changes the text in all regions:
//<upcase>text</upcase> to uppercase.
//<lowcase>text</lowcase> to lowercase
//<mixcase>text</mixcase> to mix casing(random)
'use strict';

var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";

console.log(changeRegions(text));

function changeRegions(text) {

    text = text.replace(/<upcase>([A-z ]+)<\/upcase>/g, function($tag, $textToEdit){
        return $textToEdit.toUpperCase();
    });

    text = text.replace(/<lowcase>([A-z ]+)<\/lowcase>/g, function($tag, $textToEdit){
        return $textToEdit.toLowerCase();
    });

    text = text.replace(/<mixcase>([A-z ',]+)<\/mixcase>/g, function($tag, $textToEdit){
        return mixLetters($textToEdit);
    });
    return text;
}

function mixLetters(text){
    var mixed = '',
        i, len = text.length;
    for (i = 0, len; i < len; i += 1) {
        if (i % 2 === 0) {
            mixed += text[i].toLowerCase();
        }
        else{
            mixed += text[i].toUpperCase();
        }
    }

    return mixed;
}
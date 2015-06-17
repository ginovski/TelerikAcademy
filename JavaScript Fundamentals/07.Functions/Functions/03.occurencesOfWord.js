//03.Write a function that finds all the occurrences of word in a text.
//The search can be case sensitive or case insensitive.
//Use function overloading.
'use strict';

var text = 'Hello, my name is Pesho, hello again',
    word = 'hello';

console.log("Case sensitive ---> " + findOccurrences(text, word));
console.log("Case insensitive ---> " + findOccurrences(text, word, true));

function findOccurrences(text, word, isInsensitive){
    var i, len,
        counter = 0,
        words;

    if (isInsensitive) {
        text = text.toLowerCase();
        word = word.toLowerCase();
    }

    words = text.split(/[ ,\?!-]/)
        .filter(function(item){
            return item !== '';
        });

    for (i = 0, len = words.length; i < len; i += 1) {
        if (words[i] === word) {
            counter++;
        }
    }
    
    return counter;
}

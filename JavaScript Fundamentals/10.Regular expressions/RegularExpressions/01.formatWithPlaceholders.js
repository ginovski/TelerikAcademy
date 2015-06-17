//01.Write a function that formats a string. The function should have placeholders, as shown in the example
//Add the function to the String.prototype
'use strict';
String.prototype.format = function (options){
    var result = this.replace(/#{([A-z]+)}/g, function($0, $1){
        return options[$1];
    });

    return result;
};
var text = 'My name is #{name} and I am #{age}-years-old',
    options = {name: 'John', age: 13},
    result;

result = text.format(options);

console.log(result);
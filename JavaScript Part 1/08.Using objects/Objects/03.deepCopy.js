//03.Write a function that makes a deep copy of an object.
//The function should work for both primitive and reference types.
'use strict';

var student = {
    firstName: 'Pesho',
    lastName: 'Peshev',
    grades: [2, 5, 4, 6]
    },
    primitive = "5";

function copyObject(obj) {
    var copy;
    if (obj === null || "object" !== typeof obj) {
        return obj;
    }

    if (obj instanceof Array) {
        copy = [];
        for (var i = 0 ; i < obj.length; i++) {
            copy[i] = copyObject(obj[i]);
        }

        return copy;
    }

    if (obj instanceof Object) {
        copy = {};
        for (var attr in obj) {
            if (obj.hasOwnProperty(attr)) {
                copy[attr] = copyObject(obj[attr]);
            }
        }

        return copy;
    }

    console.log("Unable copy format!");
}

var copy = copyObject(student);
console.log(copy);

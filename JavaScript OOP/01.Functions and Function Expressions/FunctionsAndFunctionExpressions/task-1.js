//1.Write a function that sums an array of numbers:
//    Numbers must be always of type Number
//Returns null if the array is empty
//Throws Error if the parameter is not passed (undefined)
//Throws if any of the elements is not convertible to Number
"use strict";

function solve(){
    return function(arr){
        if(arr.length === undefined){
            throw new Error();
        }
        if(arr.length === 0){
            return null;
        }
        return arr.reduce(function(initial, number){
            number = +number;
            if(isNaN(number)){
                throw new Error();
            }

            return initial + number;
        }, 0);
    }
}

module.exports = solve;


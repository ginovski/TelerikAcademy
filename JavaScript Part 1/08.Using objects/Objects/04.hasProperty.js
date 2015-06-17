//04.Write a function that checks if a given object contains a given property.
'use strict';

var car = {
    model: 'SLK',
    brand: 'Mercedes',
    price: 200000,
    country: 'Germany'
};

console.log(hasProperty(car, 'model'));

function hasProperty(obj, property){
    var prop;

    for (prop in obj) {
        if (prop === property) {
            return true;
        }
    }

    return false;
}

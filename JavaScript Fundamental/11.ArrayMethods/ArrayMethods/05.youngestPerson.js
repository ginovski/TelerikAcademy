//05.Write a function that finds the youngest male person in a given array of people and prints his full name
//Use only array methods and no regular loops (for, while)
//Use Array#find
'use strict';
if (!Array.prototype.find) {
    Array.prototype.find = function(predicate) {
        if (this == null) {
            throw new TypeError('Array.prototype.find called on null or undefined');
        }
        if (typeof predicate !== 'function') {
            throw new TypeError('predicate must be a function');
        }
        var list = Object(this);
        var length = list.length >>> 0;
        var thisArg = arguments[1];
        var value;

        for (var i = 0; i < length; i++) {
            value = list[i];
            if (predicate.call(thisArg, value, i, list)) {
                return value;
            }
        }
        return undefined;
    };
}

var people = createPeople();
getYoungestMalePerson(people);

function getYoungestMalePerson(people){
    var males = people.filter(function(person){
        return !person.gender;
    }).sort(function(item, nextItem){
            return item.age > nextItem.age;
        });

    var youngest = males.find(function(male){
        return male;
    });
    
    console.log(youngest.firstName + ' ' + youngest.lastName + '\nAge ' + youngest.age);
}

function createPeople(){
    var people = [];

    people.push(makePerson('Pesho', 'Goshov', 25, false));
    people.push(makePerson('Pesho', 'Mitkov', 11, false));
    people.push(makePerson('Peshka', 'Asparuhov', 35, true));
    people.push(makePerson('Pesho', 'Dimitrov', 42, false));
    people.push(makePerson('Goshka', 'Peev', 15, true));
    people.push(makePerson('Gosho', 'Grishov', 28, false));
    people.push(makePerson('Stamat', 'Stamatov', 14, false));
    people.push(makePerson('Nekva', 'Pichova', 55, true));
    people.push(makePerson('Spas', 'Grigorov', 80, false));
    people.push(makePerson('Grishata', 'Pichev', 75, false));

    function makePerson(firstName, lastName, age, gender){
        return {
            firstName: firstName,
            lastName: lastName,
            age: age,
            gender: gender
        };
    }

    return people;
}

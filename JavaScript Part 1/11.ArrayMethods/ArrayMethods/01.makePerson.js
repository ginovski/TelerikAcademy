//01.Write a function for creating persons.
//Each person must have firstname, lastname, age and gender (true is female, false is male)
//Generate an array with ten person with different names, ages and genders
'use strict';

var people = [];

people.push(makePerson('Pesho', 'Goshov', 25, false));
people.push(makePerson('Pesho', 'Mitkov', 14, false));
people.push(makePerson('Peshka', 'Asparuhov', 35, true));
people.push(makePerson('Pesho', 'Dimitrov', 42, false));
people.push(makePerson('Goshka', 'Peev', 11, true));
people.push(makePerson('Gosho', 'Grishov', 28, false));
people.push(makePerson('Stamat', 'Stamatov', 37, false));
people.push(makePerson('Nekva', 'Pichova', 55, true));
people.push(makePerson('Spas', 'Grigorov', 80, false));
people.push(makePerson('Grishata', 'Pichev', 75, false));

console.log(people);

function makePerson(firstName, lastName, age, gender){
    return {
        firstName: firstName,
        lastName: lastName,
        age: age,
        gender: gender
    };
}



//02.Write a function that checks if an array of person contains only people of age (with age 18 or greater)
//Use only array methods and no regular loops (for, while)
'use strict';

var people = createPeople();
var areMature = allMature(people);

console.log('All people are mature ---> ' + areMature);

function allMature(people){
    return people.every(function(person){
        return person.age >= 18;
    });
}

function createPeople(){
    var people = [];

    people.push(makePerson('Pesho', 'Goshov', 25, false));
    people.push(makePerson('Pesho', 'Mitkov', 18, false));
    people.push(makePerson('Peshka', 'Asparuhov', 35, true));
    people.push(makePerson('Pesho', 'Dimitrov', 42, false));
    people.push(makePerson('Goshka', 'Peev', 18, true));
    people.push(makePerson('Gosho', 'Grishov', 28, false));
    people.push(makePerson('Stamat', 'Stamatov', 37, false));
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

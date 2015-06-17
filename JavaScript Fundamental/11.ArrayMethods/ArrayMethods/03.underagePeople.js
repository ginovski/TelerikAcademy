//03.Write a function that prints all underaged persons of an array of person
//Use Array#filter and Array#forEach
//Use only array methods and no regular loops (for, while)
'use strict';

var people = createPeople();
printAllUnderAge(people);

function printAllUnderAge(people){
    people.filter(function(person){
        return person.age < 18;
    }).forEach(function(person){
        console.log(person);
    });
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

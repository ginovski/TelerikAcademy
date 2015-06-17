//06.Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
//Use Array#reduce
//Use only array methods and no regular loops (for, while)
'use strict';

var people = createPeople(),
    grouped;

grouped = groupByFirstLetterOfName(people);

console.log(grouped);

function groupByFirstLetterOfName(people) {
    var group = people.reduce(function(grouped, current){
        if (!grouped[current.firstName[0]]) {
            grouped[current.firstName[0]] = [];
        }
        grouped[current.firstName[0]].push(current);

        return grouped;
    }, {});

    return group;
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


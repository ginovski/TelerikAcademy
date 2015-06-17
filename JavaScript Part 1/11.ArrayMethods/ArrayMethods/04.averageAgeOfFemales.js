//04.Write a function that calculates the average age of all females, extracted from an array of persons
//Use Array#filter
//Use only array methods and no regular loops (for, while)
'use strict';

var people = createPeople();

printAverageAgeOfFemales(people)

function printAverageAgeOfFemales(people){
    var females,
        sumOfYears = 0;

    females = people.filter(function(person){
        return person.gender;
    });

    females.forEach(function(female){
        sumOfYears += female.age;
    });

    console.log(sumOfYears / females.length);
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

//05.Write a function that finds the youngest person in a given array of people and prints his/hers full name
//Each person has properties firstname, lastname and age.
'use strict';

var people = [
    { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
    { firstname : 'Bay', lastname: 'Ivan', age: 18},
    { firstname : 'Pesho', lastname: 'Goshov', age: 26},
    { firstname : 'Stamat', lastname: 'Asparuhov', age: 58},
    { firstname : 'Mitko', lastname: 'Toshev', age: 103},
];

getYoungestPerson(people);

function getYoungestPerson(people) {
    var youngest = people[0],
        i, len;

    for (i = 1, len = people.length; i < len; i += 1) {
        if (people[i].age < youngest.age) {
            youngest = people[i];
        }
    }
    
    console.log(youngest.firstname + ' ' + youngest.lastname + '\n' + youngest.age + ' years');
} 

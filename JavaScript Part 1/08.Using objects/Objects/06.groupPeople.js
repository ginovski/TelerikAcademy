//06.Write a function that groups an array of people by age, first or last name.
//The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
//Use function overloading (i.e. just one function)
'use strict';

var people = [
    { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
    { firstname : 'Gosho', lastname: 'Ivan', age: 18},
    { firstname : 'Pesho', lastname: 'Petrov', age: 32},
    { firstname : 'Stamat', lastname: 'Asparuhov', age: 18},
    { firstname : 'Mitko', lastname: 'Toshev', age: 103},
];

console.log(groupBy(people, 'age'));

function groupBy(people, groupByParam) {
    var grouped = {},
        i, len;

    for (i = 0, len = people.length; i < len; i += 1) {
        if (!grouped[people[i][groupByParam]]) {
            grouped[people[i][groupByParam]] = [];
        }

        grouped[people[i][groupByParam]].push(people[i]);
    }
    
    return grouped;
}

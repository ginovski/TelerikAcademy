'use strict';

function solve(params){
    function applyConversion(index, arr, length){
        var prev = arr[(index - 1) % length],
            next = arr[(index + 1) % length];
        if (index === 0) {
            prev = arr[length - 1];
        }
        if (arr[index] === 0) {
            return Math.abs(prev - next);
        }
        else if (arr[index] === 1) {
            return prev + next;
        }
        else if (arr[index] % 2 === 0) {
            return Math.max(prev, next);
        }
        else{
            return Math.min(prev, next);
        }
    }
    var n  = parseInt(params[0].split(' ')[0]),
        k = parseInt(params[0].split(' ')[1]),
        numbers = params[1].split(' ').map(Number),
        edited = [];

    for (var i = 0; i < k; i += 1) {
        for (var j = 0; j < n; j += 1) {
            edited[j] = applyConversion(j, numbers, n);
        }
        numbers = edited;
        edited = [];
    }
    
    console.log(numbers.reduce(function(initial, item){
        return initial += item;
    }, 0));
}
var args = [
    '5 1',
    '9 0 2 4 1'
];
var args2 = [
    '10 3',
    '1 9 1 9 1 9 1 9 1 9'
];
var args3 = [
    '10 10',
    '0 1 2 3 4 5 6 7 8 9'
]
solve(args);
console.log('-------------------------');
solve(args2);
console.log('-------------------------');
solve(args3);
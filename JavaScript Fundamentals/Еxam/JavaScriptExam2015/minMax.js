'use strict';

function solve(params) {
    var N = parseInt(params[0]),
        K = parseInt(params[1]),
        numbers = params[2].split(' ').map(Number),
        min = 0,
        max = 0,
        sums = [];

    for (var i = 0; i <= N - K; i += 1) {
        min = numbers[i];
        max = numbers[i];
        for (var j = i + 1; j < K + i; j += 1) {
            if (numbers[j] > max) {
                max = numbers[j];
            }
            if (numbers[j] < min) {
                min = numbers[j];
            }
        }
        sums.push(max + min);
    }

    console.log(sums.join(','));
}

solve([
    '4',
    '2',
    '1 3 1 8'
]);
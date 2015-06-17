'use strict';

function solve(params) {
    var s = params[0],
        c1 = params[1],
        c2 = params[2],
        c3 = params[3];
    var answer = 0;
    var best = 0;

    for (var i = 0; i <= s / c1; i += 1) {
        for (var j = 0; j <= s / c2; j += 1) {
            for (var k = 0; k <= s / c3; k += 1) {
                answer = i * c1 + j * c2 + k * c3;
                if (answer > best && answer <= s) {
                    best = answer;
                }
            }
        }
    }

    console.log(best);
}
var data = [
    110,
    13,
    15,
    17
];
solve(data);
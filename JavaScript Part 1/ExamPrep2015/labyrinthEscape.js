'use strict';
function solve(params){
    function generateMatrix(params, rows, cols) {
        var matrix = [];
        for (var i = 0; i < rows; i += 1) {
            matrix[i] = [];
            for (var j = 0; j < cols; j += 1) {
                matrix[i][j] = params[i + 2][j];
            }
        }

        return matrix;
    }

    function getPoints(row, col, rows, cols){
        return (row * cols) + 1 + col;
    }

    var rows = +params[0].split(' ')[0],
        cols = +params[0].split(' ')[1],
        row = +params[1].split(' ')[0],
        col = +params[1].split(' ')[1],
        points = 0,
        counter = 0;

    var directions = {
        'l': [0, -1],
        'r': [0, 1],
        'd': [1, 0],
        'u': [-1, 0]
    };

    var matrix = generateMatrix(params, rows, cols);
    while(true) {
        if (row >= rows || row < 0 || col >= cols || col < 0) {
            console.log('out ' + points);
            break;
        }
        if (matrix[row][col] === -1) {
            console.log('lost ' + counter);
            break;
        }

        points += getPoints(row, col, rows, cols);
        counter++;
        var direction = matrix[row][col];
        matrix[row][col] = -1;
        row += directions[direction][0];
        col += directions[direction][1];
    }
}
var args =[
    "3 4",
    "1 3",
    "lrrd",
    "dlll",
    "rddd"
];
var args2 =[
    "5 8",
    "0 0",
    "rrrrrrrd",
    "rludulrd",
    "durlddud",
    "urrrldud",
    "ulllllll"];
var args3 =[
    "5 8",
    "0 0",
    "rrrrrrrd",
    "rludulrd",
    "lurlddud",
    "urrrldud",
    "ulllllll"];

solve(args);
console.log('---------------------------------');
solve(args2);
console.log('---------------------------------');
solve(args3)


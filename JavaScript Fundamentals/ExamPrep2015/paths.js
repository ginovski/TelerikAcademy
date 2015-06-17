'use strict';

function solve(params){
    function getPoints(row, col) {
        return Math.pow(2, row) + col;
    }

    var rows = parseInt(params[0].split(' ')[0]),
        cols = parseInt(params[0].split(' ')[1]),
        currentRow = 0,
        currentCol = 0;
    var matrix = [];
    var points = 0;

    for (var i = 0; i < rows; i += 1) {
        matrix[i] = params[i + 1].split(' ');
    }

    var directions = {
        'dr': [1, 1],
        'ur': [-1, 1],
        'ul': [-1, -1],
        'dl': [1, -1]
    };
    while(true) {
        if (currentRow >= rows || currentCol >= cols || currentRow < 0 || currentCol < 0)  {
            console.log('successed with ' + points);
            break;
        }

        if (matrix[currentRow][currentCol] === -1) {
            console.log('failed at (' + currentRow + ', ' + currentCol + ')');
            break;
        }

        points += getPoints(currentRow, currentCol);
        var direction = matrix[currentRow][currentCol];
        var newPositionRow = directions[direction][0];
        var newPositionCol = directions[direction][1];
        matrix[currentRow][currentCol] = -1;
        currentRow += newPositionRow;
        currentCol += newPositionCol;
    }
}

solve([
    '3 5',
    'dr dl dr ur ul',
    'dr dr ul ur ur',
    'dl dr ur dl ur'
]);
solve([
    '3 5',
    'dr dl dl ur ul',
    'dr dr ul ul ur',
    'dl dr ur dl ur'
]);

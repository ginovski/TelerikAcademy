'use strict';

function solve(params){
    function getField(params){
        var field = [];
        for (var i = 0; i < rows; i += 1) {
            field[i] = [];
            for (var j = 0; j < cols; j += 1) {
                field[i][j] = params[i + 2][j];
            }
        }

        return field;
    }

    function getRowColFromPosition(position, rows){
        var letter = position[0];
        var number = parseInt(position[1]);
        var rowAndCol = [];

        rowAndCol[0] = rows - number;
        rowAndCol[1] = letter.charCodeAt(0) - 97;

        return rowAndCol;

    }

    function validKnightMove(fromRow, fromCol, toRow, toCol, knightMoves){
        for (var j = 0, len = knightMoves.length; j < len; j += 1) {
            if (knightMoves[j][0] + fromRow === toRow && knightMoves[j][1] + fromCol === toCol ) {
                return true;
            }
        }

        return false;
    }

    function checkIfPathIsEmpty(fromRow, fromCol, toRow, toCol, field) {
        var pathEmpty = true;
        if (fromCol === toCol) {
            if (fromRow > toRow) {
                for (var i = fromRow - 1; i >= toRow ; i -= 1) {
                    if (field[i][fromCol] !== '-') {
                        pathEmpty = false;
                    }
                }
            }
            else{
                for (var j = fromRow + 1; j <= toRow ; j += 1) {
                    if (field[j][fromCol] !== '-') {
                        pathEmpty = false;
                    }
                }
            }
        }
        else if (fromRow === toRow) {
            if (fromCol > toCol) {
                for (var k = fromCol - 1; k >= toCol ; k -= 1) {
                    if (field[fromRow][k] !== '-') {
                        pathEmpty = false;
                    }
                }
            }
            else{
                for (var z = fromCol + 1; z <= toCol ; z += 1) {
                    if (field[fromRow][z] !== '-') {
                        pathEmpty = false;
                    }
                }

            }
        }
        else {
            if (fromRow > toRow && fromCol > toCol) {
                while(fromRow > toRow && fromCol > toCol) {
                    fromRow -= 1;
                    fromCol -= 1;
                    if (field[fromRow][fromCol] !== '-') {
                        pathEmpty = false;
                    }
                }
            }
            else if(fromRow < toRow && fromCol > toCol){
                while(fromRow < toRow && fromCol > toCol) {
                    fromRow += 1;
                    fromCol -= 1;
                    if (field[fromRow][fromCol] !== '-') {
                        pathEmpty = false;
                    }
                }
            }
            else if(fromRow < toRow && fromCol < toCol){
                    while(fromRow < toRow && fromCol < toCol) {
                        fromRow += 1;
                        fromCol += 1;
                        if (field[fromRow][fromCol] !== '-') {
                            pathEmpty = false;
                        }
                    }
            }
            else{
                while(fromRow > toRow && fromCol < toCol) {
                    fromRow -= 1;
                    fromCol += 1;
                    if (field[fromRow][fromCol] !== '-') {
                        pathEmpty = false;
                    }
                }
            }
        }

        return pathEmpty;
    }

    var rows = parseInt(params[0]),
        cols = parseInt(params[1]),
        field = getField(params),
        tests = parseInt(params[rows + 2]),
        fromPosition = 0,
        fromRow = 0,
        fromCol = 0,
        toRow = 0,
        toCol = 0,
        toPosition = 0,
        knightMoves = [[-2, 1], [-1, 2], [1, 2], [2, 1],
        [2, -1], [1, -2], [-1, -2], [-2, -1]];

    for (var i = 0; i < tests; i += 1) {
        fromPosition = params[rows + 3 + i].split(' ')[0];
        toPosition = params[rows + 3 + i].split(' ')[1];
        fromRow = getRowColFromPosition(fromPosition, rows)[0];
        fromCol = getRowColFromPosition(fromPosition, rows)[1];
        toRow = getRowColFromPosition(toPosition, rows)[0];
        toCol = getRowColFromPosition(toPosition, rows)[1];

        if (fromPosition === toPosition) {
            console.log('no');
        }
        else if (field[fromRow][fromCol] === '-') {
            console.log('no');
        }
        else if (field[toRow][toCol] !== '-') {
            console.log('no');
        }
        else if (field[fromRow][fromCol] === 'Q') {
            if (checkIfPathIsEmpty(fromRow, fromCol, toRow, toCol, field)) {
                console.log('yes');
            }else{
                console.log('no');
            }
        }
        else if (field[fromRow][fromCol] === 'K') {
            if (validKnightMove(fromRow, fromCol, toRow, toCol, knightMoves)) {
                console.log('yes');
            }
            else {
                console.log('no');
            }
        }
    }
}

var args = [
    '3',
    '4',
    '--K-',
    'K--K',
    'Q--Q',
    '12',
    'd1 b3',
    'a1 a3',
    'c3 b2',
    'a1 c1',
    'a1 b2',
    'a1 c3',
    'a2 c1',
    'd2 b1',
    'b1 b2',
    'c3 a3',
    'a2 a3',
    'd1 d3'

];
var args2 = [

];
var args3 = [

];
solve(args);
console.log('--------------------------');
//solve(args2);
//console.log('--------------------------');
//solve(args3);

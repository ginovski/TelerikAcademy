'use strict';

function solve(params){
    function getPoints(row, col){
        return Math.pow(2, row) - col;
    }

    function getRowsAndCols(str) {
        var parts = str.split(' ');
        return [parseInt(parts[0]), parseInt(parts[1])];
    }

    function getValue(params, row, col) {
        return params[row + 1][col];
    }

    var rowsAndCols = getRowsAndCols(params[0]),
        rows = rowsAndCols[0],
        cols = rowsAndCols[1],
        row = rows - 1,
        col = cols - 1,
        points = 0,
        moves = 0,
        used = [];

    var horseMoves = [[-2, 1], [-1, 2], [1, 2], [2, 1], [2, -1], [1, -2], [-1, -2], [-2, -1]];
    
    while(true) {
        if (row >= rows || col >= cols || col < 0 || row < 0) {
            return 'Go go Horsy! Collected ' + points + ' weeds';
        }
        if (used[row + ' ' + col]) {
            return 'Sadly the horse is doomed in ' + moves + ' jumps';
        }
        used[row + ' ' + col] = true;
        points += getPoints(row, col);
        moves += 1;

        var move = horseMoves[getValue(params, row, col) - 1];
        row += move[0];
        col += move[1];
    }
}

console.log(solve(['3 5',
    '54561',
    '43328',
    '52388']));
console.log(solve([
    '3 85',
    '4228545871361134531572665621474876581741275177843485425355845655786786648413761278158',
    '1181657584763731717511721264164454722344645442681745185234814452255462867574787853385',
    '7463838874877143724175233317747581136752233532656667528668843246726138585172833761417'
]));
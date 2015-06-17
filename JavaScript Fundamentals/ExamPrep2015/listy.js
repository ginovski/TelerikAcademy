function solve(commands){
    function concatArr(arr){
        var variableValue = '';
        for (var j = 2; j < arr.length; j += 1) {
            variableValue += arr[j];
        }

        return variableValue;
    }

    function applyOperation(values, operation) {
        if (operation === 'sum') {
            var sum = 0;
            for (var k = 0; k < values.length; k += 1) {
                sum += +values[k];
            }

            return sum;
        }
        if (operation === 'min') {
            var min = values[0];
            for (var k = 1; k < values.length; k += 1) {
                if (values[k] < min) {
                    min = values[k];
                }
            }

            return min;
        }
        if (operation === 'max') {
            var max = +values[0];
            for (var k = 1; k < values.length; k += 1) {
                if (+values[k] > max) {
                    max = +values[k];
                }
            }

            return max;
        }
        if (operation === 'avg') {
            var sum = applyOperation(values, 'sum');
            var avg = sum / values.length | 0;

            return avg;
        }
    }

    function replaceWithVariableValues(values, variables){
        for (var j = 0; j < values.length; j += 1) {
            if (variables.hasOwnProperty(values[j])) {
                values[j] = variables[values[j]];
            }
        }
    }

    var i,
        length,
        currentCommands;
    var variables = {};

    var defineVariableCommand = 'def';
    for (i = 0, length = commands.length; i < length; i += 1) {
        currentCommands = commands[i].replace(/ +/g, ' ').split(' ');
        if (currentCommands[0] === defineVariableCommand) {
            variables[currentCommands[1]] = concatArr(currentCommands);
            for (var prop in variables) {
                var variable = variables[prop];
                if (typeof variable === 'string' && variable[0] !== '[') {
                    var operation = variable.substr(0, 3);
                    var items = variable.substring(variable.indexOf('[') + 1, variable.indexOf(']')).split(',');
                    replaceWithVariableValues(items, variables);
                    console.log(items);
                    variables[prop] = applyOperation(items, operation);
                }
            }
        }
    }
    console.log(variables);

}

solve([
    'def func sum[5, 3, 7, 2, 6, 3]',
    'def func2 [5, 3, 7, 2, 6, 3]',
    'def func3 min[func2]',
    'def func4 max[5, 3, 7, 2, 6, 3]',
    'def func5 avg[5, 3, 7, 2, 6, 3]',
    'def func6 sum[func2, func3, func4 ]',
    'sum[func6, func4]'
]);
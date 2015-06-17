'use strict';

function solve(params){
    var result = '';
    for (var i = 0, len = params.length; i < len; i += 1) {
        result += params[i].replace(/\s\s+/g, ' ');
        result += '\n';

        if (params[i].lastIndexOf('{') !== -1) {
            result += '  ';
        }
    }
    console.log(result.trim());
}

var args = [
    '.jedi {',
    'has: lightsaber;',
    '}',
];
var args2 = [
'#the-big-b{',
'   color: big-yellow;',
'.little-bs {',
'        color: little-yellow;',
'        $.male {',
'            color: middle-yellow;',
'        }',
'    }',
'}',
'.muppet {',
'    skin : fluffy;',
'    $.water-spirit {',
'        powers : water;',
'    }',
'    powers : all-muppet-powers;',
'}'
    ];
var args3 = [

];
//solve(args);
console.log('--------------------------');
solve(args2);
console.log('--------------------------');
//solve(args3);

//02.Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time
'use strict';

var n = 30,
    i;

for (i = 1; i <= n; i += 1) {
    if (!(i % 3) && !(i % 7)) {
        continue;
    }
    console.log(i);
} 

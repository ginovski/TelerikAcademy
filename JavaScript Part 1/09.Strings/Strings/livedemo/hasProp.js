'use strict';

var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
arr.remove(1);

Array.prototype.remove = function(element){
    var arr = this,
        removed = [];
    for (var i = 0; i < arr.length; i += 1) {
        if (arr[i] !== element) {
            removed.push(arr[i]);
        }
    }

    return removed;
};

//02.Write a function that removes all elements with a given value.
//Attach it to the array type.
//Read about prototype and how to attach methods.
'use strict';

Array.prototype.remove = function (item){
  var result = [],
      i,
      len;
    for (i = 0, len = this.length; i < len; i += 1) {
        if (this[i] !== item) {
            result.push(this[i]);
        }
    }
    
    return result;
};

var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'],
    result;

result = arr.remove(1);
console.log(result);


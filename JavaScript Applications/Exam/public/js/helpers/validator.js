var validator = (function() {
  'use strict';

  function validateEmpty(data){
    return data != "" && data != null;
  }

  function validateSize(data, min, max){
    return data.length >= min && data.length <= max;
  }

  function validatePattern(data, pattern){
    return data.match(pattern);
  }

  return {
    validateEmpty: validateEmpty,
    validateSize: validateSize,
    validatePattern: validatePattern
  }
}());

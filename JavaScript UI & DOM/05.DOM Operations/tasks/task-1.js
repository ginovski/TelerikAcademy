/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {

  return function (element, contents) {
      var domElement;
      if(element instanceof HTMLElement){
          domElement = element;
      }
      else if(typeof(element) === 'string') {
          domElement = document.getElementById(element);
      }
      else{
          throw new Error('Element is neither string or existing DOM element');
      }
      var len = contents.length;
      for(var j = 0; j < len; j += 1){
          if(typeof(contents[j]) !== 'string' && typeof(contents[j]) !== 'number'){
              throw new Error('Contents is neither string or number');
          }
      }

      domElement.innerHTML = '';
      for(var i = 0; i < len; i += 1){
          var div = document.createElement('div');
          div.innerHTML += contents[i];

          domElement.appendChild(div);
      }
  };
};
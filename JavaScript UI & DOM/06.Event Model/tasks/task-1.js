/* globals $ */

/* 

 Create a function that takes an id or DOM element and:

 If an id is provided, select the element
 Finds all elements with class button or content within the provided element
 Change the content of all .button elements with "hide"
 When a .button is clicked:
 Find the topmost .content element, that is before another .button and:
 If the .content is visible:
 Hide the .content
 Change the content of the .button to "show"
 If the .content is hidden:
 Show the .content
 Change the content of the .button to "hide"
 If there isn't a .content element after the clicked .button and before other .button, do nothing
 Throws if:
 The provided DOM element is non-existant
 The id is either not a string or does not select any DOM element

*/

function solve(){
  return function (selector) {
      var root;
      if(selector instanceof HTMLElement){
          root = selector;
      }
      else if(typeof(selector) === 'string') {
          root = document.getElementById(selector);
      }
      else{
          throw new Error('Element is neither DOM Element or selector');
      }
      var elementsInsideRoot = root.children;
      for(var i = 0; i < elementsInsideRoot.length; i += 1) {
          var currentElement = elementsInsideRoot[i];
          if (currentElement.className === 'button') {
              currentElement.innerHTML = 'hide';
          }
      }

      root.addEventListener('click', function(e){
          if(e.target.className === 'button'){
              var element = e.target;
              for(var k = 0; k < elementsInsideRoot.length; k += 1){
                  if(elementsInsideRoot[k] === element){
                      for(var z = k; z < elementsInsideRoot.length; z += 1){
                          if(elementsInsideRoot[z].className === 'content' && element.innerHTML === 'hide'){
                              elementsInsideRoot[z].style.display = 'none';
                              element.innerHTML = 'show';
                              break;
                          }
                          else if(elementsInsideRoot[z].className === 'content' && element.innerHTML === 'show'){
                              elementsInsideRoot[z].style.display = '';
                              element.innerHTML = 'hide';
                              break;
                          }
                      }
                  }
              }
          }
      });
  };
};

module.exports = solve;
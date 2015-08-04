/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
  return function (selector) {
    var root;
    if(typeof(selector) === 'string') {
      root = $(selector);
    }
    else{
      throw new Error('Element is neither DOM Element or selector');
    }

    if(!root.length){
      throw new Error('There is no such element with that selector');
    }
    var elementsInsideRoot = root.find('.button');
    elementsInsideRoot.html('hide');

    $('.button').click(function(){
        var element = $(this);
        elementsInsideRoot = root.children();
        for(var k = 0; k < elementsInsideRoot.length; k += 1){
          if($(elementsInsideRoot[k])[0] === element[0]){
            for(var z = k; z < elementsInsideRoot.length; z += 1){
              if($(elementsInsideRoot[z]).attr('class') === 'content' && element.html() === 'hide'){
                $(elementsInsideRoot[z]).css('display', 'none');
                element.html('show');
                break;
              }
              else if($(elementsInsideRoot[z]).attr('class') === 'content' && element.html() === 'show'){
                $(elementsInsideRoot[z]).css('display', '');
                element.html('hide');
                break;
              }
            }
          }
        }
    })
  };
};

module.exports = solve;
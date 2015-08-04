function solve(){
  return function(selector){
    $.fn.dropdownList = function(selector) {
        var select = $(selector);
        var dropdownWrapper = $('<div>').addClass('dropdown-list');
        var currentSelectedElement = $('<div>')
            .addClass('current')
            .attr('data-value', $(select.children()[0]).html())
            .html($(select.children()[0]).html());
        var optionsContainer = $('<div>').addClass('options-container').css({
            'position': 'absolute',
            'display': 'none'
        });

        for(var i = 0; i < select.children().length; i += 1){
            var currentSelectItem = select.children()[i];
            var option = $('<div>')
                .addClass('dropdown-item')
                .attr('data-value', $(currentSelectItem).val())
                .attr('data-index', i)
                .html($(currentSelectItem).html())
                .click(function(){
                   $('.current')
                       .html($(this).html())
                       .attr('data-value', $(this).attr('data-value'));
                });

            optionsContainer.append(option);
        }

        dropdownWrapper.append(select.css('display', 'none'));
        dropdownWrapper.append(currentSelectedElement);
        dropdownWrapper.append(optionsContainer);

        $(this).append(dropdownWrapper);

        $('.current').click(function(){
            $(this).html('Select a value');
            if($('.options-container').css('display') === 'none'){
                $('.options-container').css('display', '');
            }
            else{
                $('.options-container').css('display', 'none');
            }
        });

        $('.dropdown-item').click(function(){
            $('.options-container').css('display', 'none');
            $('.current')
                .html($(this).html())
                .attr('data-value', '');
        });
    };

      $('body').dropdownList(selector);
  };
}

module.exports = solve;
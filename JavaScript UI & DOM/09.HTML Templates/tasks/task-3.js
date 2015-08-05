function solve(){
  return function(){
    $.fn.listview = function(data){
        var i, len,
            $this = $(this);

        var source = $('#' + $this.attr('data-template')).html();
        var template = handlebars.compile(source);

        for(i = 0, len = data.length; i < len; i += 1){
            $this.append(template(data[i]));
        }
    };
  };
}

module.exports = solve;
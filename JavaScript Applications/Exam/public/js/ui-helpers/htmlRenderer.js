var htmlRenderer = (function () {
  'use strict';

  function render(htmlTemplate, data) {
      var source = htmlTemplate;
      var template = Handlebars.compile(source);

      var html = template(data);

      return html;
  }

  return {
      render: render
  };
}());

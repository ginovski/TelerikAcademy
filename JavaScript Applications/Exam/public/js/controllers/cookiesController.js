var cookiesController = (function() {
  'use strict';

  function share(context){
    partialsHelper.getTemplate('share-cookie')
      .then(function(template){
        context.$element().html(template);

        return data.cookies.categories();
      })
      .then(function(res){
        var categories = res.result;

        $('#category').autocomplete({
          source: categories
        });

        $('#share').click(function(){
          var text = $('#text').val();
          var category = $('#category').val();
          var imageUrl = $('#image').val();

          if(!validator.validateEmpty(text)){
            toastr.error('Text is required!');
            return;
          }
          if(!validator.validateSize(text, 6, 30)){
            toastr.error('Text must be between 6 and 30 symbols');
            return;
          }
          if(!validator.validateEmpty(category)){
            toastr.error('Category is required');
            return;
          }
          if(!validator.validateSize(category, 6, 30)){
            toastr.error('Category must be between 6 and 30 symbols');
            return;
          }
          if(validator.validateEmpty(imageUrl)){
            if(!validator.validatePattern(imageUrl, /^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$/)){
              toastr.error("Image URL must be valid url address");
              return;
            }
          }

          data.cookies.share(text, category, imageUrl)
            .then(function(res) {
              if(res){
                toastr.success('Cookie shared!');
                context.redirect('#/home');
              }
            });
        });
      })
  }

  function hourlyCookie(context){
    var template;
    partialsHelper.getTemplate('my-cookie')
      .then(function(templateHtml){
        template = templateHtml;
        return data.cookies.hourlyCookie();
      })
      .then(function(res){
        var cookie = res.result;
        cookie.shareDate = moment(cookie.shareDate).format("MMMM Do YYYY, HH:mm");
        var html = htmlRenderer.render(template, cookie);

        context.$element().html(html);

        $('#like').click(function(){
          var like = this;
          var cookieId = $(like).siblings('.cookie-id').text();
          data.cookies.like(cookieId)
            .then(function(res){
              if(res){
                var likes = $(like).children('.likes').text();
                likes++;
                $(like).children('.likes').text(likes);
              }
            }, function(err){
              console.log(err);
            });
        });

        $('#dislike').click(function(){
          var dislike = this;
          var cookieId = $(dislike).siblings('.cookie-id').text();
          data.cookies.dislike(cookieId)
            .then(function(res){
              if(res){
                var dislikes = $(dislike).children('.dislikes').text();
                dislikes++;
                $(dislike).children('.dislikes').text(dislikes);
              }
            });
        })
      })
  }

  return {
    share: share,
    hourlyCookie: hourlyCookie
  };
}());

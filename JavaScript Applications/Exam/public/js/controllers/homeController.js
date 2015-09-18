var homeController = (function() {
  'use strict';

  function all(context){
    var sort = context.params.sort;
    var category = context.params.category
    var template;

    partialsHelper.getTemplate('home')
      .then(function(templateHtml){
        template = templateHtml;

        return data.cookies.all();
      })
      .then(function(res){
        var cookies = res.result;

        _.map(cookies, function(cookie){
          cookie.shareDate = moment(cookie.shareDate).format("MMMM Do YYYY, HH:mm");
        })

        if(sort){
          if(sort.toLowerCase() == "likes"){
            cookies = _.sortBy(cookies, function(cookie){
              return cookie.likes;
            })
          } else if(sort.toLowerCase() == "share date"){
            cookies = _.sortBy(cookies, function(cookie){
              return new Date(cookie.shareDate);
            })
          }

          cookies.reverse();
        }

        var grouped = _.chain(cookies)
          .groupBy('category')
          .map(function(items, category) {
            return {
              category,
              items
            }
          })
          .value();

          if(category){
            grouped = _.filter(grouped, function(group){
              return group.category == category;
            })
          }

          var html = htmlRenderer.render(template, {
            cookies: grouped,
            isLogged: data.users.isLogged()
          });
          context.$element().html(html);

          if(sort){
              $('#sort').val(sort);
          }

          attachEvents(context);

          return data.cookies.categories();
      })
      .then(function(res){
        $('#category-filter').autocomplete({
          source: res.result
        });
      });
  }

  function attachEvents(context){
    $('#filter').click(function(){
      if(context.params.sort){
        context.redirect('#/home?category=' + $('#category-filter').val() + '&sort=' + context.params.sort);
      } else {
        context.redirect('#/home?category=' + $('#category-filter').val());
      }
    })

    $('#btn-sort').click(function(){
      if(context.params.category){
        context.redirect('#/home?sort=' + $('#sort').val() + '&category=' + context.params.category);
      } else {
        context.redirect('#/home?sort=' + $('#sort').val());
      }
    })

    $('.like').click(function(){
      var like = this;
      var cookieId = $(like).siblings('.cookie-id').text();
      data.cookies.like(cookieId)
        .then(function(res){
          if(res){
            var likes = $(like).children('.likes').text();
            likes++;
            $(like).children('.likes').text(likes);
          }
        });
    });

    $('.dislike').click(function(){
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
    });

    $('.reshare').click(function(){
      var $this = $(this);
      var text = $this.siblings('.text').text();
      var category = $this.siblings('.category').text();
      var img = $this.siblings('.image').attr('src');

      data.cookies.share(text, category, img)
        .then(function(res) {
          if(res){
            toastr.success('Cookie shared!');
            context.redirect('#/home');
            setTimeout(function(){
              document.location.reload(true);
            }, 1000);
          }
        });
    });
  }

  return {
    all: all
  };
}());

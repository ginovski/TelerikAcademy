$(function(){
  'use strict';
  var app = new Sammy('#content', function(){
    this.get('#/', function(){
      this.redirect('#/home');
    });
    this.get('#/home', homeController.all);
    this.get('#/my-cookie', function(){});
    this.get('#/register', usersController.register);
    this.get('#/login', usersController.login);
    this.get('#/cookies/share', cookiesController.share);
    this.get('#/myCookie', cookiesController.hourlyCookie);
  });

  partialsHelper.getTemplate('userdata')
    .then(function(template){
      var html = htmlRenderer.render(template, {
          isLogged: data.users.isLogged(),
          username: data.users.getCurrentUser() ? data.users.getCurrentUser().username : ''
        });

      $('.userdata').html(html);

      $('#logout').click(function(){
        data.users.logout();
      });
    })

  app.run('#/');
});

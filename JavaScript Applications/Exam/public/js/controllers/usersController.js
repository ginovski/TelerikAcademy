var usersController = (function() {
  'use strict';

  function register(context){
    partialsHelper.getTemplate('register')
      .then(function(template){
        context.$element().html(template);

        $('#register').click(function(){
          var username = $('#username').val();
          var password = $('#password').val();

          if(!validator.validateSize(username, 6, 30)){
            toastr.error('Username must be between 6 and 30 symbols');
            return;
          }

          if(!validator.validatePattern(username, /^([A-z0-9_.])\w+$/g)){
            toastr.error("Username can contain only Latin letters, digits and the characters '_' and '.'");
            return;
          }

          data.users.register(username, password)
            .then(function(res){
              toastr.success('Successful registration. Please login');
              context.redirect('#/login');
            }, function(err){
              toastr.error(err.responseText);
            });
        })
      })
  }

  function login(context){
    partialsHelper.getTemplate('login')
      .then(function(template){
        context.$element().html(template);

        $('#login').click(function(){
          var username = $('#username').val();
          var password = $('#password').val();

          data.users.login(username, password)
            .then(function(res){
              toastr.success("Welcome to Fortune cookies, " + res.result.username);
              context.redirect('#/home');
              document.location.reload(true);
            }, function(err){
              toastr.error(err.responseText);
            })
        })
      })
  }

  return{
    register: register,
    login: login
  }
}());

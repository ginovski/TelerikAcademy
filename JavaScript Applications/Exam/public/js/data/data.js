var data = (function() {
  'use strict';

  function register(username, password){
    var user = {
      username: username,
      passHash: CryptoJS.SHA1(password).toString()
    }

    console.log(user);

    var promise = new Promise(function(resolve, reject) {
      $.ajax({
        url: 'api/users',
        method: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(user),
        success: function(res){
          resolve(res);
        },
        error: function(err){
          reject(err);
        }
      })
    });

    return promise;
  }

  function login(username, password) {
    var newUser = {
        username: username,
        passHash: CryptoJS.SHA1(password).toString()
    };

    var promise = new Promise(function(resolve, reject) {
        $.ajax({
            url: 'api/auth',
            method: 'PUT',
            contentType: 'application/json',
            data: JSON.stringify(newUser),
            success: function(res){
                storage.setObject('user', res.result);
                resolve(res);
            },
            error: function(err) {
                reject(err);
            }
        })
    });

    return promise;
  }

  function logout(){
    storage.removeItem('user');
    toastr.success("Successful logout!");

    document.location.reload(true);
  }

  function isLogged(){
    return getCurrentUser() !== null;
  }

  function getCurrentUser(){
    return storage.getObject('user');
  }

  function all(){
    var promise = new Promise(function(resolve, reject) {
      $.ajax({
        url: 'api/cookies',
        success: function(res){
          resolve(res);
        },
        error: function(err){
          reject(err);
        }
      })
    });

    return promise;
  }

  function like(cookieId){
    var req = {
      type: 'like'
    }
    var promise = new Promise(function(resolve, reject) {
      $.ajax({
        url: 'api/cookies/' + cookieId,
        method: 'PUT',
        headers: {
          'x-auth-key': getCurrentUser().authKey
        },
        contentType: 'application/json',
        data: JSON.stringify(req),
        success: function(res){
          resolve(res);
        },
        error: function(err){
          reject(err);
        }
      });
    });

    return promise;
  }

  function dislike(cookieId){
    var req = {
      type: 'dislike'
    }
    var promise = new Promise(function(resolve, reject) {
      $.ajax({
        url: 'api/cookies/' + cookieId,
        method: 'PUT',
        headers: {
          'x-auth-key': getCurrentUser().authKey
        },
        contentType: 'application/json',
        data: JSON.stringify(req),
        success: function(res){
          resolve(res);
        },
        error: function(err){
          reject(err);
        }
      });
    });

    return promise;
  }

  function categories(){
    var promise = new Promise(function(resolve, reject) {
      $.ajax({
        url: 'api/categories',
        success: function(res){
          resolve(res);
        }
      })
    });

    return promise;
  }

  function share(text, category, imageUrl){
    var image = {
      text: text,
      category: category,
      img: imageUrl
    };

    var promise = new Promise(function(resolve, reject) {
      $.ajax({
        url: 'api/cookies',
        method: 'POST',
        contentType: 'application/json',
        headers: {
          'x-auth-key': getCurrentUser().authKey
        },
        data: JSON.stringify(image),
        success: function(res){
          resolve(res);
        },
        error: function(err){
          reject(err);
        }
      });
    });

    return promise;
  }

  function hourlyCookie(){
    var promise = new Promise(function(resolve, reject) {
      $.ajax({
        url: 'api/my-cookie',
        headers: {
          'x-auth-key': getCurrentUser().authKey
        },
        success: function(res){
          resolve(res);
        },
        error: function(err){
          reject(err);
        }
      });
    });

    return promise;
  }

  return{
    users: {
      register: register,
      login: login,
      logout: logout,
      getCurrentUser: getCurrentUser,
      isLogged: isLogged
    },
    cookies: {
      all: all,
      like: like,
      dislike: dislike,
      categories: categories,
      share: share,
      hourlyCookie: hourlyCookie
    }
  };
}());

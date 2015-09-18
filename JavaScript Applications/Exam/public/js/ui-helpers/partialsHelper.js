var partialsHelper = (function () {
    'use strict';
    
    var templates = {};
    function getTemplate(templateName) {
        var promise = new Promise(function (resolve, reject) {
            if(templates[templateName]){
                resolve(templates[templateName]);
            } else {
            $.get('templates/' + templateName + '.handlebars')
                .then(function (partial) {
                    templates[templateName] = partial;
                    resolve(partial);
                }, function (err) {
                    reject(err);
                });
            }
        });

        return promise;
    }

    return {
        getTemplate: getTemplate
    };
}());

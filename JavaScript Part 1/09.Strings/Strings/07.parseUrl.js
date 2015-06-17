//07.Write a script that parses an URL address given in the format: [protocol]://[server]/[resource]
//and extracts from it the [protocol], [server] and [resource] elements.
//Return the elements in a JSON object.
'use strict';

var url = 'http://telerikacademy.com/Courses/Courses/Details/239';
var parsedUrl = parseUrl(url);

console.log(parsedUrl);

function parseUrl(url){
    var protocol,
        server,
        resource,
        indexOfFirstSlash,
        indexOfResource;

    protocol = url.substring(0, url.indexOf(':'));

    indexOfFirstSlash = url.indexOf('/');
    server = url.substring(url.indexOf('/', indexOfFirstSlash + 1) + 1, url.indexOf('/', indexOfFirstSlash + 3));

    indexOfResource = url.substring(url.lastIndexOf('.'), url.indexOf('/', indexOfFirstSlash + 3)).length + url.lastIndexOf('.');
    resource = url.substr(indexOfResource);
    
    return {
        protocol: protocol,
        server: server,
        resource: resource
    };
}

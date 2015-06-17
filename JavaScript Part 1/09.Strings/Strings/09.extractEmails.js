//09.Write a function for extracting all email addresses from given text.
//All sub-strings that match the format @… should be recognized as emails.
//Return the emails as array of strings.
'use strict';

var text = 'Hello pesho@abv.bg, feel free to ask us at mitaka@hotmail.com or grishata@gmail.com';

var emails = extractEmails(text);
console.log(emails);

function extractEmails(text) {
    return text.match(/[A-z._]+@[A-z.]+/g);
}
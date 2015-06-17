//10.Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
'use strict';

var palindrome = 'lamal';
console.log(checkPalindrome(palindrome));

function checkPalindrome(palindrome) {
    var reversedPalindrome = '';
    for (var i = 0, len = palindrome.length; i < len; i += 1) {
        reversedPalindrome += palindrome[len - i - 1];
    }

    return palindrome === reversedPalindrome;
}

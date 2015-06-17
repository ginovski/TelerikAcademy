//08.Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
'use strict';

var number = 503,
    numberAsString = '';

if (number >= 0 && number <= 999)
{
    var ones = number % 10;
    number = Math.floor(number / 10);
    var tens = number % 10;
    number = Math.floor(number / 10);
    var hundreds = number % 10;

    switch (hundreds)
    {
        case 1:
            numberAsString += "One Hundred ";
            break;
        case 2:
            numberAsString += "Two Hundred ";
            break;
        case 3:
            numberAsString += "Three Hundred ";
            break;
        case 4:
            numberAsString += "Four Hundred ";
            break;
        case 5:
            numberAsString += "Five Hundred ";
            break;
        case 6:
            numberAsString += "Six Hundred ";
            break;
        case 7:
            numberAsString += "Seven Hundred ";
            break;
        case 8:
            numberAsString += "Eight Hundred ";
            break;
        case 9:
            numberAsString += "Nine Hundred ";
            break;
        case 0:
            break;
    }
    switch (tens)
    {
        case 1:
            if (hundreds == 0)
            {
                break;
            }
            else {
                numberAsString += "and";
            }
            break;
        case 2:
            numberAsString += "Twenty ";
            break;
        case 3:
            numberAsString += "Thirty ";
            break;
        case 4:
            numberAsString += "Fourty ";
            break;
        case 5:
            numberAsString += "Fifty ";
            break;
        case 6:
            numberAsString += "Sixty ";
            break;
        case 7:
            numberAsString += "Seventy ";
            break;
        case 8:
            numberAsString += "Eighty ";
            break;
        case 9:
            numberAsString += "Ninety ";
            break;
        case 0:
            if (ones == 0)
            {
                break;
            }
            else if(hundreds > 0)
            {
                numberAsString += "and ";
            }
            break;
    }
    switch (ones)
    {
        case 1 :
            if (tens == 1)
            {
                numberAsString += "Eleven";
            }
            else if (tens == 0 && hundreds == 0)
            {
                numberAsString += "One";
            }
            else if (tens == 0)
            {
                numberAsString += "One";
            }
            else
            {
                numberAsString += "One";
            }
            break;
        case 2:
            if (tens == 1)
            {
                numberAsString += "Twelve";
            }
            else if (tens == 0 && hundreds == 0)
            {
                numberAsString += "Two";
            }
            else if (tens == 0)
            {
                numberAsString += "Two";
            }
            else
            {
                numberAsString += "Two";
            }
            break;
        case 3:
            if (tens == 1)
            {
                numberAsString += "Thirteen";
            }
            else if (tens == 0 && hundreds == 0)
            {
                numberAsString += "Three";
            }
            else if (tens == 0)
            {
                numberAsString += "Three";
            }
            else
            {
                numberAsString += "Three";
            }
            break;
        case 4:
            if (tens == 1)
            {
                numberAsString += "Fourteen";
            }
            else if (tens == 0 && hundreds == 0)
            {
                numberAsString += "Four";
            }
            else if (tens == 0)
            {
                numberAsString += "Four";
            }
            else
            {
                numberAsString += "Four";
            }
            break;
        case 5:
            if (tens == 1)
            {
                numberAsString += "Fifteen";
            }
            else if (tens == 0 && hundreds == 0)
            {
                numberAsString += "Five";
            }
            else if (tens == 0)
            {
                numberAsString += "Five";
            }
            else
            {
                numberAsString += "Five";
            }
            break;
        case 6:
            if (tens == 1)
            {
                numberAsString += "Sixteen";
            }
            else if (tens == 0 && hundreds == 0)
            {
                numberAsString += "Six";
            }
            else if (tens == 0)
            {
                numberAsString += "Six";
            }
            else
            {
                numberAsString += "Six";
            }
            break;
        case 7:
            if (tens == 1)
            {
                numberAsString += "Seventeen";
            }
            else if (tens == 0 && hundreds == 0)
            {
                numberAsString += "Seven";
            }
            else if (tens == 0)
            {
                numberAsString += "Seven";
            }
            else
            {
                numberAsString += "Seven";
            }
            break;
        case 8:
            if (tens == 1)
            {
                numberAsString += "Eighteen";
            }
            else if (tens == 0 && hundreds == 0)
            {
                numberAsString += "Eight";
            }
            else if (tens == 0)
            {
                numberAsString += "Eight";
            }
            else
            {
                numberAsString += "Eight";
            }
            break;
        case 9:
            if (tens == 1)
            {
                numberAsString += "Nineteen";
            }
            else if (tens == 0 && hundreds == 0)
            {
                numberAsString += "Nine";
            }
            else if (tens == 0)
            {
                numberAsString += "Nine";
            }
            else
            {
                numberAsString += "Nine";
            }
            break;
        case 0:
            if (tens == 0 && hundreds == 0)
            {
                numberAsString += "Zero";
            }
            else if(tens == 1)
            {
                numberAsString += "Ten";
                break;
            }
            break;
    }
}
else
{
    numberAsString += "Wrong input";
}

console.log(numberAsString);

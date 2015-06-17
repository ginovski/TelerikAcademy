//07.Write a script that finds the greatest of given 5 variables.
//Use nested if statement
'use strict';

var numberOne = 5,
    numberTwo = 2,
    numberThree = 2,
    numberFour = 4,
    numberFive = 1;

if (numberOne >= numberTwo){
    if (numberOne >= numberThree) {
        if (numberOne >= numberFour) {
            if (numberOne >= numberFive) {
                console.log(numberOne);
            }
        }
    }

}
if (numberTwo >= numberOne) {
    if (numberTwo >= numberThree) {
        if (numberTwo >= numberFour) {
            if (numberTwo >= numberFive) {
                console.log(numberTwo);
            }
        }
    }

}
if (numberThree >= numberOne) {
    if (numberThree >= numberTwo) {
        if (numberThree >= numberFour) {
            if (numberThree >= numberFive) {
                console.log(numberThree);
            }
        }
    }
}
if (numberFour >= numberOne) {
    if (numberFour >= numberTwo) {
        if (numberFour >= numberThree) {
            if (numberFour >= numberFive) {
                console.log(numberFour);
            }
        }
    }
}
if (numberFive >= numberOne) {
    if (numberFive >= numberTwo) {
        if (numberFive >= numberThree) {
            if (numberFive >= numberFour) {
                console.log(numberFive);
            }
        }
    }
}
//2.Write a function that finds all the prime numbers in a range
//It should return the prime numbers in an array
//It must throw an Error if any of the range params is not convertible to Number
//It must throw an Error if any of the range params is missing
"use strict";

function solve(from, to){
	var primes = [],
		isPrime = true,
		maxDivider;

	if(from === undefined || to === undefined){
		throw new Error();
	}

	from = +from;
	to = +to;

	if(isNaN(from) || isNaN(to)){
		throw new Error();
	}

	for (var i = from; i <= to; i++) {
		if(i < 2){
			i = 2;
		}
		maxDivider = Math.sqrt(i);
		isPrime = true;
		for (var j = 2; j <= maxDivider; j++) {
			if(i % j === 0){
				isPrime = false;
				break;
			}
		}

		if(isPrime){
			primes.push(i);
		}
	}

	return primes;
}

module.exports = solve;

/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error 		
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {
	var Person = (function () {
		function Person(firstname, lastname, age) {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
		}

        function checkIfValidChars(name){
            for(var i = 0, len = name.length; i < len; i += 1){
                if((name.charCodeAt(i) >= 65 && name.charCodeAt(i) <= 90) ||
                    (name.charCodeAt(i) >= 97 && name.charCodeAt(i) <= 122)){
                    continue;
                }

                return false;
            }

            return true;
        }

        function isNameValid(name){
            if(name.length < 3 || name.length > 20){
                return false;
            }
            if(!checkIfValidChars(name)){
                return false;
            }

            return true;
        }

        Object.defineProperty(Person.prototype, 'firstname', {
            get: function(){
                return this._firstname;
            },
            set: function(firstname){
                if(!isNameValid(firstname)){
                    throw new Error('Invalid firstname');
                }

                this._firstname = firstname;
                return this;
            }
        });

        Object.defineProperty(Person.prototype, 'lastname', {
            get: function(){
                return this._lastname;
            },
            set: function(lastname){
                if(!isNameValid(lastname)){
                    throw new Error('Invalid firstname');
                }

                this._lastname = lastname;
                return this;
            }
        });

        Object.defineProperty(Person.prototype, 'age', {
            get: function(){
                return this._age;
            },
            set: function(age){
                age = parseInt(age);
                if(isNaN(age)){
                    throw new Error();
                }
                if(age < 0 || age > 150){
                    throw new Error();
                }

                this._age = age;
                return this;
            }
        });

        Object.defineProperty(Person.prototype, 'fullname', {
            get: function(){
                return this.firstname + ' ' + this.lastname;
            },
            set: function(fullname){
                var firstName = fullname.split(' ')[0],
                    lastName = fullname.split(' ')[1];

                this.firstname = firstName;
                this.lastname = lastName;
                return this;
            }
        });

        Person.prototype.introduce = function(){
            return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
        };
		
		return Person;
	} ());

	return Person;
}

module.exports = solve;
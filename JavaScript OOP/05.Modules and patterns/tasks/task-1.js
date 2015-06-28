/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
    var id = 1;
    function validStudentId(students, studentID){
        return students.some(function(st){
            return st.id === studentID;
        })
    }

    function validHomeworkId(presentations, homeworkID){
        return presentations.some(function(item, index){
            return index + 1 === homeworkID;
        })
    }
    
    function checkIfStringStartsWithUppercase(str){
        return str.charCodeAt(0) >= 65 && str.charCodeAt(0) <= 90;
    }

    function spacesInTitle(presentations){
        for (var i = 0, len = presentations.length; i < len; i += 1) {
            var presentation = presentations[i];
            for (var j = 0, l = presentation.length; j < l - 1; j += 1) {
                if (presentation[j] === ' ' && presentation[j] === presentation[j + 1]) {
                    return true;
                }
            }
        }

        return false;
    }

    function validTitle(presentations){
        for (var i = 0, len = presentations.length; i < len; i += 1) {
            if (presentations[i] === '') {
                return false;
            }
        }

        return true;
    }

	var Course = {
		init: function(title, presentations) {
            this.title = title;
            this.presentations = presentations;
            this.students = [];
            this.homeworks = [];
            this.examResults = [];
            return this;
		},
		addStudent: function(name) {
            if (typeof name !== 'string') {
                throw new Error('Student name must be string');
            }
            var names = name.split(' ');
            if (names.length !== 2) {
                throw new Error('Student must have only two names');
            }

            var firstName = names[0],
                lastName = names[1];
            if (!checkIfStringStartsWithUppercase(firstName) || !checkIfStringStartsWithUppercase(lastName)) {
                throw new Error('Names must start with capital letter');
            }
            var studentId = id++;

            this.students.push({
                firstname: firstName,
                lastname: lastName,
                id: studentId
            });
            return studentId;
		},
		getAllStudents: function() {
            return this.students.slice();
		},
		submitHomework: function(studentID, homeworkID) {
            if (!validStudentId(this.students, studentID)) {
                throw new Error('Invalid student id');
            }
            if (!validHomeworkId(this.presentations, homeworkID)) {
                throw new Error('Invalid homework id');
            }
            this.homeworks.push({
                studentID: studentID,
                homeworkID: homeworkID
            });
            return this;
		},
		pushExamResults: function(results) {
            this.examResults = results;
            return this;
		},
		getTopStudents: function() {
            // TODO: Implement when tests are available
		},
        get title(){
            return this._title;
        },
        set title(value){
            if (value.length === 0) {
                throw new Error('Course title cannot be empty');
            }
            if (value[0] === ' ' || value[value.length - 1] === ' ') {
                throw new Error('Title name cannot begin and end with space');
            }

            this._title = value;
            return this;
        },
        get presentations(){
            return this._presentations;
        },
        set presentations(presentations){
            if (presentations.length === 0) {
                throw new Error('There must be at least one presentation');
            }
            if (!validTitle(presentations)) {
                throw new Error('Title can not be empty string');
            }
            if (spacesInTitle(presentations)) {
                throw new Error('Titles cannot have spaces');
            }

            this._presentations = presentations;
            return this;
        }
	};

	return Course;
}


module.exports = solve;

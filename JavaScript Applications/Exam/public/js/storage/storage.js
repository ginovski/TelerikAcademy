var storage = (function(){
	'use strict';
	
	function getObject(key){
		var result = localStorage.getItem(key);

		return JSON.parse(result);
	}

	function setObject(key, obj){
		var objString = JSON.stringify(obj);

		localStorage.setItem(key, objString);
	}

	function removeItem(key){
		localStorage.removeItem(key);
	}

	return {
		getObject: getObject,
		setObject: setObject,
		removeItem: removeItem
	};
}());

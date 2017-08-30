/******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};

/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {

/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId])
/******/ 			return installedModules[moduleId].exports;

/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			exports: {},
/******/ 			id: moduleId,
/******/ 			loaded: false
/******/ 		};

/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);

/******/ 		// Flag the module as loaded
/******/ 		module.loaded = true;

/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}


/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;

/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;

/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";

/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(0);
/******/ })
/************************************************************************/
/******/ ([
/* 0 */
/***/ function(module, exports, __webpack_require__) {

	'use strict';

	var _iterator = __webpack_require__(1);

	(0, _iterator.iterator)(); //document.write('Hello from ES6!!'); 
	//console.log('ES6 app loaded'); 

	//import {testConstant} from './components/constant.js';
	//testConstant();

	//import {testScoping} from './components/scoping.js';
	//testScoping();

	//import {enhancedObjProp} from './components/EnhancedObjProps.js';
	//enhancedObjProp();

	//import {arrow} from './components/arrow.js';
	//arrow();

	//import {ExtendedParamHandling} from './components/ExtendedParamHandling.js';
	//ExtendedParamHandling();

	//import {TemplateVars} from './components/TemplateVars.js';
	//TemplateVars();

	//import {destructuring} from './components/destructuring.js';
	//destructuring();

	//import {classModules} from './components/classModules.js';
	//classModules();

	//import {symbol} from './components/symbol.js';
	//symbol();

/***/ },
/* 1 */
/***/ function(module, exports) {

	"use strict";

	Object.defineProperty(exports, "__esModule", {
	    value: true
	});
	exports.testamstrong = testamstrong;

	function _defineProperty(obj, key, value) { if (key in obj) { Object.defineProperty(obj, key, { value: value, enumerable: true, configurable: true, writable: true }); } else { obj[key] = value; } return obj; }

	var i, n, temp, rem;
	var start = 0;
	var end = 1000;
	var amstrong = _defineProperty({}, Symbol.iterator, function () {
	    return {
	        next: function next() {
	            for (i = start + 1; i < end; i++) {
	                temp = i;
	                n = 0;
	                while (temp != 0) {
	                    rem = temp % 10;
	                    n = n + rem * rem * rem;
	                    temp = parseInt(temp / 10);
	                }
	                if (i == n) {

	                    console.log(i);
	                }
	            }
	        }
	    };
	});
	function testamstrong() {
	    var itr = amstrong[Symbol.iterator]();
	    console.log(itr.next());
	}

/***/ }
/******/ ]);
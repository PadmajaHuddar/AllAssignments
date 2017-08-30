function calcAge(){
	var ageInput = document.getElementById("age").value;
	var today= new Date();
	today= today.getFullYear();
	var year= today-ageInput;
	alert("Your birth year is "+year);
}
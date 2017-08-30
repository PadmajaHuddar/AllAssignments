/*function validation(){
	var alpha= document.getElementById("alpha").value;
	if((isNaN(alpha)==true)
	{
		alert("Please enter an alphabetic value);
	}
	
}*/

function alphaCheck(){
	var alpha=document.getElementById("alpha").value;
	if(alpha=='a'||alpha=='e'||alpha=='i'||alpha=='o'||alpha=='u'||alpha=='A'||alpha=='E'||alpha=='I'||alpha=='O'||alpha=='U')
	{
		alert("The alphabet entered is an vowel");
	}
	else{
		alert("The alphabet entered is a consonent");
	}
}

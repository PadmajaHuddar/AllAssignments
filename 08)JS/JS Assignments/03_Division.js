function validation(){
	var no= document.getElementById("no2").value;
	if(no<=0)
	{
		alert("Invalid input for second number. Please re-enter."); 
	}
}

function calculate(){
	var no1=document.getElementById("no1").value;
	var no2=document.getElementById("no2").value;
	var ans=no1/no2;
	alert("Answer of division is: "+ans);
}

function validation(){
	var no= document.getElementById("no").value;
	if(no<=0)
	{
		alert("Invalid input. Please re-enter."); 
	}
}

function calculate(){
	var fact=1,i;
	var no=document.getElementById("no").value;
	for(i=1;i<=no;i++)
	{
		fact=fact*i;
	}
	alert("Factorial is: "+fact);
}

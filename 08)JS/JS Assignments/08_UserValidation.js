var inc=0;

function validate(){
	inc=inc+1;
	var uname= "padmaja";
	var pwd= "xoriant123#";
	var unameInp= document.getElementById("uname").value;
	var pwdInp= document.getElementById("pwd").value;

	if(uname==unameInp&&pwd==pwdInp)
	{
		document.write("Hello "+uname+" welcome!!");
	}
	else
	{
		alert("Incorrect username or password...");
		document.getElementById("uname").reset;
		document.getElementById("pwd").reset;
	}
	
	if(inc>=3)
	{
		document.write("Incorrect Entry for more than three time. Try again later!");    
	}
}
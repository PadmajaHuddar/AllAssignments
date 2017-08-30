function validation(){
	var no= document.getElementById("no").value;
	if(no<=0)
	{
		alert("Invalid input. Please re-enter."); 
	}
}

function calculate(){
	var i=1;
	var no=document.getElementById("no").value;
	document.write("Table for "+no+" :");
	do{
		for(i=1;i<=10;i++)
		{
			var table= no*i;
			document.write(no+" * "+i+" = "+table);
			document.write("<br>");
		}
		no++;
	}while(confirm("Next Table??"));
}

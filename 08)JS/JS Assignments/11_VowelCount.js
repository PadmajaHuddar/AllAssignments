function count(){
	var val= document.getElementById("sentence").value;
	var index=0,a=0,e=0,i=0,o=0,u=0;
	val= val.toLowerCase();
	for(index=0;index<val.length;index++)
	{
		var valueAtIndex =val.charAt(index);
		if(valueAtIndex=='a')
		{
			a++;
		}
		else if(valueAtIndex=='e'){e++;}
		else if(valueAtIndex=='i'){i++;}
		else if(valueAtIndex=='o'){o++;}
		else if(valueAtIndex=='u'){u++;}
	}
	document.write("a= "+a+" e= "+e+" i= "+i+" o= "+o+" u= "+u);
}
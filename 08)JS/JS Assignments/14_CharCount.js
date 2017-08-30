function count(){
	var sentence= document.getElementById("sentence").value;
	var output='';
	for(var index=0;index<sentence.length;index++)
	{
		if(sentence.charAt(index)!==' ')
		{
			output+=sentence.charAt(index);
		}
	}
	alert("Characters: "+output.length);
}

function palindrome(){
	var word= document.getElementById("word").value;
	word = word.toLowerCase();
	var n = word.length;
	for (var i = 0; i < (n/2); ++i)
	{
		if (word.charAt(i) != word.charAt(n - i - 1))
		{
			flg=0;
			alert("Not a Palindrome!!");
			break;
		}
		else
		{
			flg=1;
		}
	}
	if(flg==1)
	{
		alert("Palindrome!!");	
	}
}

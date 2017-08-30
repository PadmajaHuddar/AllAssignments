function compute()
{
	var total=0, i=0;
	var arr =[5, 10, 15, 9, 56, 89];
	document.write("Given array "+arr+"<br>");
	document.write("Maximum is: "+ Math.max(...arr)+"<br>");
	document.write("Maximum is: "+ Math.min(...arr)+"<br>");
	var sum=0;
	for(i=0;i<arr.length;i++)
	{
		sum=sum+arr[i];
	}
	document.write("Sum is: "+sum+"<br>");
	document.write("Average is: "+sum/arr.length+"<br>");
}
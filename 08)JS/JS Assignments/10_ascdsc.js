function order()
{
	var value= document.getElementById("sort").value;
	var arr=[1,89,98,55,5,2,4,3,22];
	
	for (i = 0; i < arr.length; ++i)
    {
        for (j = i + 1; j < arr.length; ++j)
        {
            if (arr[i] > arr[j])
            {
                a =  arr[i];
                arr[i] = arr[j];
                arr[j] = a;
            }
        }
    }
	if(value=="Ascending")
	{
		alert("Ascending order is: "+arr);
	}
	else
	{
		alert("Descending order is: "+arr.reverse());
	}
}
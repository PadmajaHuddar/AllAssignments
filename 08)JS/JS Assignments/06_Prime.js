function calculate(){
	var no1=document.getElementById("no1").value;
	var no2=document.getElementById("no2").value;
	for(i = no1; i <= no2; i++)
         {
             for( j = 2; j < i; j++)
             {
                 if(i % j == 0)
                 {
                     flag = 0;
                     break;
                 }
                 else
                 {
                     flag = 1;
                 }
             }
             if(flag == 1)
             {
                 document.write(i);
				 document.write("<br>");;
             }
         }
}

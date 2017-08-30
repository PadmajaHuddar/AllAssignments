export function testScoping()
{
    if(10>5)
    {
         let i= 50;
         console.log("Vaule of i: ",i);     
    }
    console.log("Vaule of i: ",i);
}
import 'regenerator-runtime/runtime';
function *myGen()
{
    let start = 0; 
    let end = 1000; 
    var i,rem,temp,n;
    for(i=start+1; i<end; i++)
    {
        temp = i;
        n = 0;
        while(temp != 0)
        {
            rem = temp%10;
            n = n + rem*rem*rem;
            temp = parseInt(temp/10);
        }
        if(i == n)
        {
          if(reset)
          {
              start=0;
              end=1000;
              i=1;
          }
          let reset= yield i;
        }
        try
        {
            if(i>=999)
            {
                start=0;
                end=1000;
                i=0;
                throw 0;
            }
        }
        catch(msg){
            console.log("Value greater than 1000");
        }
    }
}

export function generator()
{
    let gen= myGen();
    console.log(gen.next().value);
    console.log(gen.next().value);
    console.log(gen.next(true).value);
    console.log(gen.next().value);
    console.log(gen.next().value);
    console.log(gen.next().value);
    console.log(gen.next().value);
    console.log(gen.next().value);
    console.log(gen.next().value);
    console.log(gen.next().value);
    console.log(gen.next().value);
}
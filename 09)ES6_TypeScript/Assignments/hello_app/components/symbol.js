export function symbol()
{
    let prev_no= Symbol();
    let curr_no= Symbol();
    class Fibonacci
    {
        constructor(prev,curr)
        {
            this[prev_no]=prev;
            this[curr_no]=curr;
        }
        next(){
            [this[prev_no],this[curr_no]]=[this[curr_no],this[prev_no]+this[curr_no]];
            return {done:false, value:this[curr_no]};
        }
    }
    let obj=new Fibonacci(0,1);
    for (var i=0;i<10;i++)
    {
       console.log("Fibonacci no: ", obj.next());
    }
}
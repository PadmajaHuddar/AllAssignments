export function promise()
{
    let sum=0;
    var p1 = Promise.resolve(20);
    var p2 = Promise.resolve(30);
    Promise.all([p1, p2]).then((promises)=> {
        promises.forEach(p =>{ sum+=p;
                               console.log("Number ",p) });
        console.log("Sum is :",sum);
    });
}
export function arrow()
{
    let names = ['Tom', 'Ivan', 'Jerry'];
    let arr=[];
    names.forEach(f=> {
            let obj={name:f,length:f.length};
            console.log(obj);
            arr.push(obj);
        })
    console.log(arr);       
}
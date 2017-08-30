interface Printable
{
    print:()=>void;
}

let circle: Printable={
    print:()=>console.log("In Circle")
}

let employee:Printable={
    print:()=>console.log("In Employee")
}

function printAll(circle:Printable,employee:Printable):void
{
    circle.print();
    employee.print();
}

printAll(circle,employee);
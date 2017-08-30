export function ExtendedParamHandling()
{
    //DEFAULT VALUES
    let add= (a=12,b=18) => { let c=a+b;
        console.log("Addition of "+a+" and "+b+" is: ",c);}
    add();

    //REST PARAMETERS
    function userFriends(userName,...Friends){
        console.log("Username "+userName+" has friends ",Friends);
    }
    userFriends("Padmaja","Sneha","Ekta","Myself");

    //SPREAD OPERATOR
    function printCapitalNames(n1,n2,n3,n4,n5){
        console.log(n1+" to Uppercaae ",n1.toUpperCase());
        console.log(n2+" to Uppercaae ",n2.toUpperCase());
        console.log(n3+" to Uppercaae ",n3.toUpperCase());
        console.log(n4+" to Uppercaae ",n4.toUpperCase());
        console.log(n4+" to Uppercaae ",n5.toUpperCase());
    }
    let arr=["aarti","bunty","chinty","dolly","ekta"];
    printCapitalNames(...arr);
}
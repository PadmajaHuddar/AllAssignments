export function enhancedObjProp()
{
    let order={
        id:26,
        title:"Chocolate",
        price:250,
        printOrder(){return this.id;},
        getPrice(){return this.price;}
    }
    var copy= Object.assign({ },order);
    console.log(order.printOrder());
    console.log(copy.getPrice());
    console.log("Copy obj: ",copy);
}
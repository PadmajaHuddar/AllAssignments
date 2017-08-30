export function destructuring()
{
    //ARRAY MATCHING
    let [,,values,]=["1st value","2nd value","3rd value","4th value"];
    console.log("3rd position value is ",values);

    //DEEP MATCHING
    let orgObj = {
         name: "Padmaja", 
         address: { street: "Baner Road", 
                    city: "Pune", 
                    state: "Maharashtra", 
                    pincode: "411045" 
                } 
            };
    let {address: {city, pincode}} = orgObj;
    console.log("City: ",city," Pincode: "+pincode); 

}
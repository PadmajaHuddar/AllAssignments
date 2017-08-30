import { Injectable } from '@angular/core';

@Injectable() 


export class AdvertisementService { 
    advertisements: Array<any> = [];
    editadvertisements: Array<any> = [];
    setAd(obj:any)
    {
        this.advertisements.push(obj);
        console.log(this.advertisements);
    }
    getAllAdvertisements() { return this.advertisements; }

    deleteAd(id:number){
        for(let index of this.advertisements)
        {
            if(id===index.id)
            {
                let newId= this.advertisements.indexOf(index);
                this.advertisements.splice(newId,1);
            }
        }
    }
    prefill(id:number)
{
        for(let index of this.advertisements){
        if(id==index.id){
        return(index);
        }}
}
    getAd(obj:any)
    {
        this.editadvertisements.push(obj);
        console.log(this.editadvertisements);
    }
}
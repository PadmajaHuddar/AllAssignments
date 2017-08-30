import {Component, EventEmitter} from '@angular/core';
import { AdvertisementService } from "../../service/products/AdvertisementService.service";

@Component({
    selector:'AdvertisementForm',
    templateUrl:'./AdvertisementForm.html'
})

export class AdvertisementForm{
    counter: number = 0;
    defaultName: string='Padmaja Huddar';
    title='Advertisement Form';
    categories : string[];
    //advertisements: Array<any>=[];
    public childEvent = new EventEmitter<any>();
    constructor(private AdvertisementService: AdvertisementService)
    { 
        this.categories = ['Furniture', 'Hardware', 'Mobile'];
    }        

    submitAdvertisement(titleRef:any, nameRef:any, categoryRef:any, descripRef:any)
    {
        this.counter++;
        let obj={id:this.counter,title:titleRef, name:nameRef, category:categoryRef, description:descripRef};
        this.AdvertisementService.setAd(obj);
       // this.advertisements.push({'title':titleRef,'name':nameRef,'category':categoryRef,'description':descripRef});
    }
}

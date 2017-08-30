import {Component} from '@angular/core';
import { AdvertisementService } from "../../service/products/AdvertisementService.service";
import {Router, ActivatedRoute} from '@angular/router';

@Component({
    selector:'AdvertisementTable',
    templateUrl:'./AdvertisementTable.html'
})

export class AdvertisementTable{
    public values: Array<any>=[];
    constructor(private AdvertisementService: AdvertisementService, private Router:Router,private activatedRoute: ActivatedRoute)
    {
        this.values=this.AdvertisementService.getAllAdvertisements();
    }
    delete(id:number)
    {
        this.AdvertisementService.deleteAd(id);
    }
    edit(id:any,title:any, name:any, category:any, description:any)
    {
        let obj={id:id,title:title, name:name, category:category, description:description};
        this.AdvertisementService.getAd(obj);
        this.Router.navigate(['/edit',id]);
    }  
}
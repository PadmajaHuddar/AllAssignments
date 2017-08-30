import { Component, OnInit } from '@angular/core';
import {ActivatedRoute} from '@angular/router';
import { AdvertisementService } from "../../service/products/AdvertisementService.service";

@Component({
    selector:'my-app',
    templateUrl: './edit.html'
})

export class edit implements OnInit {
    Advertisement:any={};
    id: number;
    title: string;
    name: string;
    quantity: number;
    description: string;
    editnumber: any;
    constructor(private activatedRoute: ActivatedRoute, private AdvertisementService: AdvertisementService )
    {}
    categories=[{id:1,name:"Furniture"},
              {id:2,name:"Hardware"},
              {id:3,name:"Mobile"}];
    ngOnInit(): void {
        this.editnumber=this.activatedRoute.snapshot.params['id'];
        this.Advertisement=this.AdvertisementService.prefill(this.editnumber);
        this.id=this.Advertisement.id;
        console.log(this.Advertisement.id);
        this.title=this.Advertisement.title;
        this.name=this.Advertisement.name;
        this.description=this.Advertisement.description;
    }
}
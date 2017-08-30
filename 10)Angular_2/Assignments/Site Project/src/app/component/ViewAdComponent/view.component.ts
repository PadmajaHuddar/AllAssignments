import { Component } from '@angular/core';
import { Router } from "@angular/router/src";
import { Login } from "../../services/Login/Login.service";

@Component({
    selector: 'view',
  templateUrl: `./view.html`,
  styleUrls: [`./view.css`]
})

export class ViewAd{
    token: any;

    constructor(private login: Login)
    {this.show();}
    ngDoCheck()
    {
        this.token= this.login.getAdDetails();
    }

    category=this.token.category;
    show(){
    console.log(this.token);
}
    categoryId=this.token.categoryId;
    createdDate=this.token.createdDate;
    description=this.token.description;
    id=this.token.id;
    name=this.token.name;
}
import { Component } from '@angular/core';
import { Router, ActivatedRoute } from "@angular/router";
import { Http, Response } from '@angular/http';
import { Login } from "../../services/Login/Login.service";
import { AdvertisementService } from "../../services/Advertisement/AdvertisementService.service";

@Component({
    selector: 'UserIdComponent',
    templateUrl: `./userId.html`,
    styleUrls :['./userId.css']
})
export class UserIdComponent {
    phone: any;
    email: any;
    username: any;
    lastName: any;
    firstName: any;
    userDetails1: any;
    userDetails: any;
    userName: any;
    token: any;

    constructor(private router: Router, private activatedRoute: ActivatedRoute, private adservices: AdvertisementService, private loginservices: Login) {
        this.userName = this.loginservices.getUname();
        this.token = this.loginservices.getToken();
        this.loginservices.getUserProfile().subscribe((response: any) => {
            this.userDetails = response.data['user'];
            this.firstName = this.userDetails.firstName;
            this.lastName = this.userDetails.lastName;
            this.username = this.userDetails.userName;
            this.email = this.userDetails.email;
            this.phone = this.userDetails.phone;

            console.log("name:",this.firstName)
            this.loginservices.setUserData(this.userDetails);
            this.userDetails1 = this.loginservices.getUserData();

            console.log("user:",this.userDetails);
            console.log(response);

        })
    }

}

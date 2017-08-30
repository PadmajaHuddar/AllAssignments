import { Component } from '@angular/core';
import { Login } from "../../services/Login/Login.service";
import { Router } from "@angular/router";


@Component({
  selector: 'my-app',
  templateUrl: `./Login.html`,
  styleUrls: ['../../HomeComponent/Home.css']
})
export class LoginComponent  { 
    authToken: any;
    flag: any;
    constructor(private router: Router, private Login: Login) { }
    checkLogin(uname:any, pwd:any) 
    {
        let sendLoginDetails={
        userName: uname,
        password: pwd }
        this.Login.setUname(sendLoginDetails.userName);
        this.Login.userLogin(sendLoginDetails).subscribe((response)=>{
            this.flag=response;
            console.log(response);
            this.authToken= this.flag.data['auth-token'];
            this.Login.setResponse(this.flag);
            if(this.authToken==null)
            {
                this.flag=false;
                alert("Invalid Username or Password.");
            }
            else
            {
                this.Login.setToken(this.authToken);
                this.flag= true;
                this.router.navigate(['/home',this.authToken,sendLoginDetails.userName]);
            }   
        })
    }
}

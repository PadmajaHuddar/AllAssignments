import { Component } from '@angular/core';
import { Router } from "@angular/router";
import { Login } from "../../services/Login/Login.service";

@Component({
  selector: 'Navigate',
  templateUrl: `./Navigate.html`,
  styleUrls: [`../../HomeComponent/Home.css`]
})

export class NavComponent  {
  userName: string;
  logoutToken: any;
  token: any;
  constructor(private router: Router,  private login: Login) { }
  /*ngOnInit() {
     this.authtoken = this.activatedRoute.snapshot.params['auth-token']; 
     this.name = this.activatedRoute.snapshot.params['userName']; 
  }*/
  
  ngDoCheck()
  {
    this.token= this.login.getToken();
    this.userName= this.login.getUname();
  }
  logout(){
        this.logoutToken= this.token;
        this.token=null;
        this.login.logoutUser(this.logoutToken).subscribe((response)=>{}, (error)=>{});
        this.login.setToken(null);
        this.router.navigate(['']);
  }

}
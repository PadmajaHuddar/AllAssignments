import { Component } from '@angular/core';
import { Router } from "@angular/router";
import { Login } from "../../services/Login/Login.service";

@Component({
  selector: 'my-app',
  templateUrl: `./Register.html`,
  styleUrls: ['./Register.css']
})
export class RegisterComponent  { 

  message: any;
  record: any;
  constructor(private router: Router, private Login: Login) { }
    insertRegistrationInfo(firstNameValue:any,lastNameValue:any,userNameValue:any,passwordValue:any,emailValue:any,phonenoValue:any) 
    {
        let sendRegistrationDetails={
        firstName: firstNameValue,
        lastName: lastNameValue,
        userName: userNameValue,
        password: passwordValue,
        email: emailValue,
        phone: phonenoValue
        }
        this.Login.userRegister(sendRegistrationDetails).subscribe((response)=>{
            this.record=response;
            console.log(response);
            this.message= this.record.data['message'];
                            if(this.message==null)
                            {
                                this.record=false;
                                alert("Inavlid registration");
                            }
                            else
                            {
                                this.record= true;
                                alert("Registed!! Please Login again.");
                                this.router.navigate(['/login']);
                            }
        })
    }
}

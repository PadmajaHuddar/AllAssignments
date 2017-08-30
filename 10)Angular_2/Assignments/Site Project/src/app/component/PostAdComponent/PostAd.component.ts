import { Component } from '@angular/core';
import { AdvertisementService } from "../../services/Advertisement/AdvertisementService.service";
import { Login } from "../../services/Login/Login.service";
import { Router } from "@angular/router";

@Component({
  selector: 'my-app',
  templateUrl: `./PostAd.html`,
  styleUrls: [`../../HomeComponent/Home.css`]
})
export class PostAdComponent  { 
    id: any;
    responses: any;
    message: any;
  record: any;
  authtoken: any;
  categories: Array<any> = [];
  constructor(private AdvertisementService:AdvertisementService, private login: Login, private Router:Router)
  {
    this.AdvertisementService.getCategory().subscribe((data)=> 
        { 
            this.categories=data.data.itemList;
            console.log('Received products: ', this.categories) 
        });
  }
   /* this.AdvertisementService.getCategory().subscribe((response:any)=> { 
    response.data.itemList.forEach((item:any)=>{
    this.categories.push(item.name);
    console.log("Categories ",this.categories);
    console.log(response);
    })
  });*/
  ngDoCheck()
  {
          this.responses= this.login.getResponse();
  }

  postAd(titleVal:any,nameVal:any,categoriesVal:any,descriptionVal:any) 
    {
        this.authtoken = this.responses.data['auth-token'];
        console.log("Token:::: ",this.authtoken);
        let sendAdvDetails={
        title: titleVal,
        name: nameVal,
        category: categoriesVal,
        description: descriptionVal
    };
    console.log("Log: ",sendAdvDetails);
        this.login.postAdvertisement(sendAdvDetails,this.authtoken).subscribe((data:any)=>{
            this.record=data,
            console.log(data);
            this.id=this.record.data['id'];
            if(this.id==null)
            {
                alert("Unsucessful post!!");
            }
            else
            {
                alert("Ad posted successfully!!");
                this.Router.navigate(['/home']);
            }
          })
    }
   /* editAd(id:any,title:any, name:any, category:any, description:any)
    {
        let obj={id:id,title:title, name:name, category:category, description:description};
        this.AdvertisementService.getAd(obj);
        this.Router.navigate(['/editAd',categoryId]);
    }  
}
(click)="this.router.navigate(['/editAd']);"*/
/*  this.message= this.record.data['message'];
                            if(this.message==null)
                            {
                                this.record=false;
                                alert("Inavlid registration");
                            }
                            else
                            {
                                this.record= true;
                                this.router.navigate(['/home']);
                            }
*/
}
import { Component, OnInit } from '@angular/core';
import { AdvertisementService } from "../../services/Advertisement/AdvertisementService.service";
import { Login } from "../../services/Login/Login.service";
import { ActivatedRoute} from '@angular/router';

@Component({
  selector: 'my-app',
  templateUrl: `./EditAd.html`,
  styleUrls: [`../../HomeComponent/Home.css`]
})
export class EditAdComponent implements OnInit { 
    editnumber: any;
    description: any;
    name: any;
    title: any;
    id: any;
    responses: any;
    message: any;
  record: any;
  authtoken: any;
  categories: Array<any> = [];
  Advertisement:any={};
  constructor(private AdvertisementService:AdvertisementService, private login: Login,private activatedRoute: ActivatedRoute)
  {}
 /* categories=[{id:1,name:"Cloths"},
              {id:2,name:"Furniture"},
              {id:3,name:"Mobile"},
              {id:1,name:"Real Estate"}];*/
    ngOnInit(): void {
        this.editnumber=this.activatedRoute.snapshot.params['id'];
        this.Advertisement=this.AdvertisementService.prefill(this.editnumber);
        this.id=this.Advertisement.id;
        console.log(this.Advertisement.id);
        this.title=this.Advertisement.title;
        this.name=this.Advertisement.name;
        this.description=this.Advertisement.description;
    }
  /*ngDoCheck()
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
          })
    }
   */
}
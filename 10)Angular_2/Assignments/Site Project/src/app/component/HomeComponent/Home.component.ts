import { Component } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { AdvertisementService } from "../../services/Advertisement/AdvertisementService.service";
import { Login } from "../../services/Login/Login.service";

@Component({
  selector: 'my-app',
  templateUrl: `./Home.html`,
  styleUrls: [`./home.css`]
})
export class HomeComponent  {
  productsarray: any[];
  allproducts: any[]=[];
  array: any[]=[];
  reg: any;
  authtoken: any;
  responses: any;
  record: any;
  token: any;
  response:any;
  advertisements: Array<any> = [];
  categories: Array<any>=[];
  constructor(private router: Router, private AdvertisementService:AdvertisementService, private login:Login){
      AdvertisementService.getPostedAds().subscribe((response:any)=>{
        console.log(response);
        response.data.advertiseList.forEach((ad:any)=>{
          this.advertisements.push({"title":ad.title,"username":ad.name,"data":ad.createdDate,"category":ad.category,"description":ad.description,"id":ad.id});
        })
      });
      this.AdvertisementService.getCategory().subscribe((data)=> 
        { 
            this.categories=data.data.itemList;
            console.log('Received products: ', this.categories) 
        });
  }
  ngDoCheck()
  {
    this.token= this.login.getToken();
    this.responses= this.login.getResponse();
  }
  viewAd(Postid:any){
    console.log(Postid);
        this.authtoken = this.responses.data['auth-token'];
        console.log(this.authtoken);
        this.AdvertisementService.viewAdvertisement(Postid,this.authtoken).subscribe((response)=>{
            this.record=response.data['mypost'];
            this.login.setAdDetails(this.record);
            console.log("Response home:",response);
            this.router.navigate(['/view']);
        })
    
  }

  productsbycategory(search:string)
  {
    this.reg=this.AdvertisementService.productscategory();
    this.reg.subscribe((data:any)=>
    {
        console.log('Data:',data);
        this.allproducts=data.data.advertiseList;
        this.productsarray = this.allproducts;
        console.log('All Ad details :',this.allproducts)
        console.log('productsArray :',this.productsarray)
        this.array=[];
        for(let product of this.productsarray){

        console.log(product.category);
        if(product.category == search){
            console.log('searched product:',product);
            this.array.push(product)
            console.log(this.array);
        }
        }
    }
    )
  }

 
}

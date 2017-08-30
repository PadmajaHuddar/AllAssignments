import { Component, Injectable } from '@angular/core';
import { Http, Response, RequestOptions, Headers } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()

 export class AdvertisementService { 
    authtoken: any;
    advertisements: Array<any> = [];
    editadvertisements: Array<any> = [];
    constructor(private _http: Http) { }
     getCategory(){
         return this._http.get('http://192.168.3.144:9000/categories').map((response: Response)=>response.json());
     } 
     getPostedAds(){
         return this._http.get('http://192.168.3.144:9000/posts/search').map((response: Response)=>response.json());
     } 
     prefill(id:number)
     {
        for(let index of this.advertisements){
        if(id==index.id){
        return(index);
        }}
     }
    getAd(obj:any)
    {
        this.editadvertisements.push(obj);
        console.log(this.editadvertisements);
    }
    viewAdvertisement(Post:any, authtoken:any)
    { 
      
        console.log("In service");
        let url = "http://192.168.3.144:9000/viewAd?postId="+Post; 
        let headers = new Headers();
        headers.append('auth-token', authtoken);
        headers.append('Content-Type', 'application/json');
        let options = new RequestOptions({ headers: headers });
        return this._http.get(url, options).map((response: Response)=>response.json());
    }

    productscategory(){
        let url = "http://192.168.3.144:9000/posts/search";
        return this._http.get(url)
        .map((response:Response)=>response.json());
    }

 }
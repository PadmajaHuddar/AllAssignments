import { Component, Injectable } from '@angular/core';
import { Http, Response, RequestOptions, Headers } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()

 export class Login { 
    userDetails: any;
    responsead: any;
    responses: any;
    uname: string;
    token: any;

    constructor(private _http: Http) { }
    
    userLogin(userlogin:any){
        let url = "http://192.168.3.144:9000/login"; 
        let headers = new Headers();
        headers.append('Content-Type', 'application/json');
        let options = new RequestOptions({ headers: headers });
        return this._http.post(url, JSON.stringify(userlogin), options).map((response: Response)=>response.json());
    }

    userRegister(userRegister:any){
        let url = "http://192.168.3.144:9000/register"; 
        let headers = new Headers();
        headers.append('Content-Type', 'application/json');
        let options = new RequestOptions({ headers: headers });
        return this._http.post(url, JSON.stringify(userRegister), options).map((response: Response)=>response.json());
    }

    postAdvertisement(AdDetails:any,Token:any){
        console.log("In service");
        let url = "http://192.168.3.144:9000/postAd"; 
        let headers = new Headers();
        headers.append('auth-token', Token);
        headers.append('Content-Type', 'application/json');
        let options = new RequestOptions({ headers: headers });
        return this._http.post(url, JSON.stringify(AdDetails), options).map((response: Response)=>response.json());
    }

    logoutUser(Token:any){
        let url = "http://192.168.3.144:9000/logout"; 
        let headers = new Headers();
        headers.append('auth-token', Token);
        let options = new RequestOptions({ headers: headers });
        return this._http.delete(url, options).map((response: Response)=>response.json());
    }
    setToken(Token:any)
    {
        this.token= Token;
        console.log("Token: ",this.token);
    }
    getToken()
    {
        return this.token;
    }
    setUname(userName:any)
    {
        this.uname= userName;
        console.log("username: ",this.uname);
    }
    getUname()
    {
        return this.uname;
    }
    setResponse(Responses:any)
    {
        this.responses=Responses;
        console.log(this.responses);
    }
    getResponse()
    {
        return this.responses;
    }

    setAdDetails(Responses:any)
    {
        this.responsead=Responses;
        console.log(this.responsead);
    }
    getAdDetails()
    {
        return this.responsead;
    }
    getUserProfile(){

        console.log("In service:", this.token);
        let url = "http://192.168.3.144:9000/user?userId="+this.uname;
        let headers = new Headers();
        headers.append('auth-token', this.token);
        //headers.append('Content-Type', 'application/json');

        let options = new RequestOptions({ headers: headers });
        return this._http.get(url,  options).map((response: Response) => response.json());
    }

    setUserData(userDetails: any)
    {
         this.userDetails = userDetails;
    }

    getUserData()
    {
         return this.userDetails;
    }
}
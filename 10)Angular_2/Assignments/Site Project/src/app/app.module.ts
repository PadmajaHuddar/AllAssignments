import { NgModule }      from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { HttpModule } from '@angular/http';

import { AppComponent }  from './app.component';
import { HomeComponent}  from './component/HomeComponent/Home.component';
import { LoginComponent}  from './component/LoginComponent/Login.component';
import { NavComponent}  from './component/NavHeader/Navigate.component';
import { RegisterComponent}  from './component/RegisterComponent/Register.component';
import { PostAdComponent}  from './component/PostAdComponent/PostAd.component';
import { EditAdComponent}  from './component/EditAdComponent/EditAd.component';
import { ViewAd}  from './component/ViewAdComponent/view.component';
import {UserIdComponent} from './component/UserIdComponent/UserId.component'

@NgModule({
  imports:      [ BrowserModule,FormsModule,ReactiveFormsModule,HttpModule ,
                RouterModule.forRoot([ 
                  {  path: '', component: HomeComponent},       
                  {  path: 'home', component: HomeComponent}, 
                  {  path: 'view', component: ViewAd}, 
                  {  path: 'home/:auth-token/:userName', component: HomeComponent},            
                  {  path: 'login', component: LoginComponent}, 
                  {  path: 'register', component: RegisterComponent},
                  {  path: 'postAd', component: PostAdComponent}, 
                  {  path: 'editAd/:categoryId', component: EditAdComponent}, 
                  {  path: 'UserIdComponent', component: UserIdComponent} ])
                ],
  declarations: [ AppComponent,HomeComponent, LoginComponent, RegisterComponent,NavComponent,PostAdComponent,UserIdComponent, EditAdComponent,ViewAd],
  bootstrap:    [ AppComponent ]
})
export class AppModule {}

import { NgModule }      from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import {RouterModule} from '@angular/router';

import { AppComponent }  from './app.component';
import {AdvertisementForm} from './components/AdvertisementFormComponent/advertisementForm.component';
import {AdvertisementTable} from './components/AdvertisementTableComponent/AdvertisementTable.component';
import {TemplateDrivenForm} from './components/TemplateDrivenForm/TemplateDriven.component';
import {ModelDrivenForm} from './components/ModelDrivenForm/ModelDriven.component';
import {MDFwithFormBuilder} from './components/MDFwithFormBuilder/MDFwithFormBuilder.component';
import {home} from './components/home/home.component';
import {edit} from './components/edit/edit.component';


import {Search} from './pipes/search';

@NgModule({
  imports:      [ BrowserModule,FormsModule,ReactiveFormsModule,RouterModule.forRoot([ {path: '', component: home}, {path: 'edit/:id', component: edit}]) ],
  declarations: [ AppComponent, AdvertisementForm, AdvertisementTable, Search, TemplateDrivenForm, ModelDrivenForm, MDFwithFormBuilder, home,edit],
  bootstrap:    [ AppComponent ]
})

export class AppModule { }

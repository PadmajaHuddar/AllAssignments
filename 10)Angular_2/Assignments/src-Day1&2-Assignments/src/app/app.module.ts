import { NgModule }      from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';


import { AppComponent }  from './app.component';
import {AdvertisementForm} from './components/AdvertisementFormComponent/advertisementForm.component';
import {AdvertisementTable} from './components/AdvertisementTableComponent/AdvertisementTable.component';
import {TemplateDrivenForm} from './components/TemplateDrivenForm/TemplateDriven.component';
import {ModelDrivenForm} from './components/ModelDrivenForm/ModelDriven.component';
import {MDFwithFormBuilder} from './components/MDFwithFormBuilder/MDFwithFormBuilder.component';


import {Search} from './pipes/search';

@NgModule({
  imports:      [ BrowserModule,FormsModule,ReactiveFormsModule ],
  declarations: [ AppComponent, AdvertisementForm, AdvertisementTable, Search, TemplateDrivenForm, ModelDrivenForm, MDFwithFormBuilder],
  bootstrap:    [ AppComponent ]
})

export class AppModule { }

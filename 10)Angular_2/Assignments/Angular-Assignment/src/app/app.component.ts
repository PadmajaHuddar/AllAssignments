import { Component } from '@angular/core';
import { AdvertisementService } from './service/products/AdvertisementService.service';

@Component({
  selector: 'my-app',
  template:`<router-outlet></router-outlet>`,
  providers: [AdvertisementService] 
})

export class AppComponent  { }

 /*  childData:Object;
   objarr:Array<any>=[];
 retrieve(newadv:any):void
   {
      this.objarr.push(newadv);
   }*/

  /*template: `<AdvertisementForm (childEvent)="retrieve($event)"></AdvertisementForm>
  <AdvertisementTable [values]="objarr"></AdvertisementTable>`,*/
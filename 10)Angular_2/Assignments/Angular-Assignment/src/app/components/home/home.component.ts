import { Component } from '@angular/core';
import { AdvertisementService } from '../../service/products/AdvertisementService.service';

@Component({
  selector: 'my-app',
  template:`<AdvertisementForm></AdvertisementForm><AdvertisementTable></AdvertisementTable>`
})
export class home { }
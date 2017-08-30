import { Component } from '@angular/core';
import { AdvertisementService } from "./services/Advertisement/AdvertisementService.service";
import { Login } from "./services/Login/Login.service";

@Component({
  selector: 'my-app',
  template: `<Navigate></Navigate><router-outlet></router-outlet>`,
  providers: [AdvertisementService, Login]
})
export class AppComponent  {}

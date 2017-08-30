import {Component } from '@angular/core'
import { FormControl, FormGroup, Validators } from '@angular/forms'

@Component({
    selector:'ModelDrivenForm',
    templateUrl:'./ModelDrivenForm.html'
})

export class ModelDrivenForm{
    productForm = new FormGroup({ 
                                    name: new FormControl(null, [Validators.required, Validators.minLength(3),Validators.maxLength(8)]), 
                                    quantity: new FormControl(20), 
                                    price: new FormControl()
                                });
}

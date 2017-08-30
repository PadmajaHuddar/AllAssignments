import { Component } from '@angular/core'
import { FormControl, FormGroup, Validators, FormBuilder } from '@angular/forms'

@Component({
    selector:'MDFwithFormBuilder',
    templateUrl:'./MDFwithFormBuilder.html'
})

export class MDFwithFormBuilder{
    productForm: FormGroup; constructor(private formBuilder: FormBuilder) {
         this.productForm = this.formBuilder.group({ 
              name: [null, [Validators.required, Validators.minLength(3), Validators.maxLength(8)]],
              quantity: [], 
              price: [] });
    }
}

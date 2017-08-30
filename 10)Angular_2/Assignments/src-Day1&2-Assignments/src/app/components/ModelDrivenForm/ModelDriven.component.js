"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var ModelDrivenForm = (function () {
    function ModelDrivenForm() {
        this.productForm = new forms_1.FormGroup({
            name: new forms_1.FormControl(null, [forms_1.Validators.required, forms_1.Validators.minLength(3), forms_1.Validators.maxLength(8)]),
            quantity: new forms_1.FormControl(20),
            price: new forms_1.FormControl()
        });
    }
    return ModelDrivenForm;
}());
ModelDrivenForm = __decorate([
    core_1.Component({
        selector: 'ModelDrivenForm',
        templateUrl: './ModelDrivenForm.html'
    })
], ModelDrivenForm);
exports.ModelDrivenForm = ModelDrivenForm;
//# sourceMappingURL=ModelDriven.component.js.map
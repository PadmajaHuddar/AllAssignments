"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var platform_browser_1 = require("@angular/platform-browser");
var app_component_1 = require("./app.component");
var advertisementForm_component_1 = require("./components/AdvertisementFormComponent/advertisementForm.component");
var AdvertisementTable_component_1 = require("./components/AdvertisementTableComponent/AdvertisementTable.component");
var TemplateDriven_component_1 = require("./components/TemplateDrivenForm/TemplateDriven.component");
var ModelDriven_component_1 = require("./components/ModelDrivenForm/ModelDriven.component");
var MDFwithFormBuilder_component_1 = require("./components/MDFwithFormBuilder/MDFwithFormBuilder.component");
var search_1 = require("./pipes/search");
var AppModule = (function () {
    function AppModule() {
    }
    return AppModule;
}());
AppModule = __decorate([
    core_1.NgModule({
        imports: [platform_browser_1.BrowserModule, forms_1.FormsModule, forms_1.ReactiveFormsModule],
        declarations: [app_component_1.AppComponent, advertisementForm_component_1.AdvertisementForm, AdvertisementTable_component_1.AdvertisementTable, search_1.Search, TemplateDriven_component_1.TemplateDrivenForm, ModelDriven_component_1.ModelDrivenForm, MDFwithFormBuilder_component_1.MDFwithFormBuilder],
        bootstrap: [app_component_1.AppComponent]
    })
], AppModule);
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map
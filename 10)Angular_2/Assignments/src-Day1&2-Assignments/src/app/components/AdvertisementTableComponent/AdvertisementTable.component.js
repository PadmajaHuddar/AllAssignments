"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var core_1 = require("@angular/core");
var AdvertisementTable = (function () {
    function AdvertisementTable() {
        this.values = [];
    }
    AdvertisementTable.prototype.delete = function (id) {
        for (var _i = 0, _a = this.values; _i < _a.length; _i++) {
            var index = _a[_i];
            if (id === index.id) {
                var newId = this.values.indexOf(index);
                this.values.splice(newId, 1);
            }
        }
    };
    return AdvertisementTable;
}());
AdvertisementTable = __decorate([
    core_1.Component({
        selector: 'AdvertisementTable',
        templateUrl: './AdvertisementTable.html',
        inputs: ['values']
    })
], AdvertisementTable);
exports.AdvertisementTable = AdvertisementTable;
//# sourceMappingURL=AdvertisementTable.component.js.map
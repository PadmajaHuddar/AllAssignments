import { Injectable } from '@angular/core';

@Injectable() 


export class ProductService { 
    products = [ { id: 1,
                   name: 'Chair', 
                   price: 3000, 
                   quantity: 25},
                 { id: 1,
                   name: 'Pen',
                   price: 200, 
                   quantity: 60} ];
            getProducts() { return this.products; }
}

import {Component} from '@angular/core';

@Component({
    selector:'AdvertisementTable',
    templateUrl:'./AdvertisementTable.html',
    inputs: ['values']
})

export class AdvertisementTable{
    public values: Array<any>=[];
    delete(id:number)
    {
        for(let index of this.values)
        {
            if(id===index.id)
            {
                let newId= this.values.indexOf(index);
                this.values.splice(newId,1);
            }
        }
    }
}
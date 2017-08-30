import {Pipe, PipeTransform} from '@angular/core'

@Pipe({
    name:'Search'
})


export class Search implements PipeTransform{
    transform(value: any[], ...args:string[]): any[]
  {
        let arr:Array<any>=[];
        if(args[0]=='' || args[0]==undefined || value==undefined)
        {
            return value;
        }
        value.forEach((advertise) => {
            if(advertise.name.includes(args[0]) || advertise.title.includes(args[0])  || advertise.category.includes(args[0]))
            {
                arr.push(advertise);
                console.log(advertise);
            }
        })
    return arr;
  }
}
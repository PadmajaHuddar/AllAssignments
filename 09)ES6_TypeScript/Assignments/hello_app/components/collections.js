export function collections()
{
    let musicuser= new Set();
    musicuser.add("Padmaja");
    musicuser.add("Sneha");
    musicuser.add("Ekta");

    let musicmsg=['Hey','Hello','I like music'];

    let sportsuser= new Set();
    sportsuser.add("Padmaja");
    sportsuser.add("Sneha");
    sportsuser.add("Ekta");
    
    let sportmsg=['Hey','Hello','I like Sports'];

    let musicMap=new Map();
    musicMap.set('musicChat',musicmsg);

    let sportsMap=new Map();
    sportsMap.set('sportsChat',sportmsg);

    let musicuarr = [...musicuser]; 
    console.log(musicuarr);

    console.log(...musicmsg);

    let sportuarr = [...sportsuser]; 
    console.log(sportuarr);
    console.log(...sportmsg);

    for (let key of musicMap.entries()) { console.log(key[0], key[1]);  } 
    for (let key of sportsMap.entries()) { console.log(key[0], key[1]); } 
}
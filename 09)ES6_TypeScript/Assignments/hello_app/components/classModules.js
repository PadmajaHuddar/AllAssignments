export function classModules()
{
    class Account{
        constructor(accid, accname, accbal)
        {
            this.accid=accid;
            this.accname=accname;
            this.accbal=accbal;
        }
        getBalance()
        {
            return this.accbal;
        }
    }

    class SavingsAccount extends Account{
        constructor(accid, accname, accbal,interest)
        {
            super(accid, accname, accbal);
            this.interest=interest;
        }
        getBalance()
        {
            return this.interest+this.accbal;
        }
    }

    
    class CurrentAccount extends Account{
        constructor(accid, accname, accbal,cashcredit)
        {
            super(accid, accname, accbal);
            this.cashcredit=cashcredit;
        }
        getBalance()
        {
            return this.cashcredit+this.accbal;
        }
    }

    let bal=[];
    let s1= new SavingsAccount("S1","Padmaja",5000,500);
    bal.push(s1);
    let s2= new SavingsAccount("S2","Sneha",2000,200);
    bal.push(s2);
    let s3= new SavingsAccount("S3","Ekta",3000,300);
    bal.push(s3);
    let c1= new SavingsAccount("C1","Sakshi",6000,600);
    bal.push(c1);
    let c2= new SavingsAccount("C2","Tejashree",2000,100);
    bal.push(c2);
    let c3= new SavingsAccount("C3","Aishwarya",2000,300);
    bal.push(c3);

    function getTotalBankBal(bal)
    {
        let sum=0;
        bal.forEach(
            f=>{
                sum=sum+f.getBalance();
            }
        );
        console.log(sum);
    }

    getTotalBankBal(bal);
}
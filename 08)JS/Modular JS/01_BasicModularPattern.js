var BankAccounts = new BankAccount(112,10000,"Padmaja");
	
function BankAccount(accNo,accBal,accName){
	this.accNo=accNo;
	this.accBal=accBal;
	this.accName=accName;
	this.deposite= function(amt){
		this.accBal+=amt;
	},
	this.withdraw= function(amt){
		this.accBal-=amt;
	}
}

function Bank(_accNo,_accBal,_accName){
	var accno=_accNo;
	var accbal=_accBal;
	var accname=_accName;
	
	return{
		depo: function(amt)
		{
			accbal+=amt;
			alert("New Balance after deposite: "+accbal+" For back account: "+accno+" Name:"+accname);
		},
		draw: function(amt)
		{
			accbal-=amt;
			alert("New Balance after withdraw: "+accbal+" For back account: "+accno+" Name:"+accname);
		},
		fill: function(number,balance,name)
		{
			accno=number;
			accbal=balance;
			accname=name;
		},
		getamount: function()
		{
			return accbal;
		},
		getaccno: function()
		{
			return accno;
		}
	}
}

var bank=new Bank("ABC4567",9000,"Albert");

function testAccount(){
	document.write("Original balance: "+BankAccounts.accBal+" For back account: "+BankAccounts.accNo+" Name:"+BankAccounts.accName+"<br>");
	BankAccounts.deposite(3000);
	document.write("New Balance after deposite: "+BankAccounts.accBal+"<br>");
	BankAccounts.withdraw(1000);
	document.write("New Balance after withdrawal: "+BankAccounts.accBal);
	bank.depo(3000);
	bank.draw(3000);
	alert("Balance for "+bank.getaccno()+" is "+bank.getamount());
}

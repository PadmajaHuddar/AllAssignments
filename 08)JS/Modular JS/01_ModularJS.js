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


function testAccount(){
	document.write("Original balance: "+BankAccounts.accBal+"<br>");
	BankAccounts.deposite(3000);
	document.write("New Balance after deposite: "+BankAccounts.accBal+"<br>");
	BankAccounts.withdraw(1000);
	document.write("New Balance after withdrawal: "+BankAccounts.accBal);

}

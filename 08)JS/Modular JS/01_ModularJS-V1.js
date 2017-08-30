var BankAccount={
	accNo: "ABC1154",
	accBal: 34099,
	accName: "Padmaja",
	deposite: function(amt){
		this.accBal= this.accBal+amt;
	},
	withdraw: function(amt){
		this.accBal= this.accBal-amt;
	}
};

function testAccount(){
	document.write("Original balance: "+BankAccount.accBal+"<br>");
	BankAccount.deposite(3000);
	document.write("New Balance after deposite: "+BankAccount.accBal+"<br>");
	BankAccount.withdraw(1000);
	document.write("New Balance after withdrawal: "+BankAccount.accBal);

}

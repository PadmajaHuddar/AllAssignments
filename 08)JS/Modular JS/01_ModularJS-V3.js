var BankAccount={
	accNo: "Null",
	accBal: 0.0,
	accName: "Unknown",
	deposite: function(amt){
		this.accBal= this.accBal+amt;
	},
	withdraw: function(amt){
		this.accBal= this.accBal-amt;
	}
};

var BankAccount= Object.create(BankAccount);

function testAccount(){
	BankAccount.accNo="ABC9900";
	BankAccount.accBal=23000;
	BankAccount.accNm="Padmaja";
	alert(BankAccount.accNm);
	document.write("Original balance: "+BankAccount.accBal+"<br>");
	BankAccount.deposite(3000);
	document.write("New Balance after deposite: "+BankAccount.accBal+"<br>");
	BankAccount.withdraw(1500);
	document.write("New Balance after withdrawal: "+BankAccount.accBal);

}

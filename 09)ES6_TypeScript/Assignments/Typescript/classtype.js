var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Account = (function () {
    function Account(accid, accname, accbal) {
        this.accid = accid;
        this.accname = accname;
        this.accbal = accbal;
    }
    Account.prototype.getBalance = function () {
        return this.accbal;
    };
    return Account;
}());
var SavingsAccount = (function (_super) {
    __extends(SavingsAccount, _super);
    function SavingsAccount(accid, accname, accbal, interest) {
        var _this = _super.call(this, accid, accname, accbal) || this;
        _this.interest = interest;
        return _this;
    }
    SavingsAccount.prototype.getBalance = function () {
        return this.interest + this.accbal;
    };
    return SavingsAccount;
}(Account));
var CurrentAccount = (function (_super) {
    __extends(CurrentAccount, _super);
    function CurrentAccount(accid, accname, accbal, cashcredit) {
        var _this = _super.call(this, accid, accname, accbal) || this;
        _this.cashcredit = cashcredit;
        return _this;
    }
    CurrentAccount.prototype.getBalance = function () {
        return this.cashcredit + this.accbal;
    };
    return CurrentAccount;
}(Account));
var s1 = new SavingsAccount("S1", "Padmaja", 5000, 500);
//bal.push(s1);
var s2 = new SavingsAccount("S2", "Sneha", 2000, 200);
//bal.push(s2);
var s3 = new SavingsAccount("S3", "Ekta", 3000, 300);
//bal.push(s3);
var c1 = new SavingsAccount("C1", "Sakshi", 6000, 600);
//bal.push(c1);
var c2 = new SavingsAccount("C2", "Tejashree", 2000, 100);
//bal.push(c2);
var c3 = new SavingsAccount("C3", "Aishwarya", 2000, 300);
//bal.push(c3);
var bal = [s1, s2, s3, c1, c2, c3];
function getTotalBankBal(bal) {
    var sum = 0;
    bal.forEach(function (f) {
        sum = sum + f.getBalance();
    });
    console.log(sum);
}
getTotalBankBal(bal);

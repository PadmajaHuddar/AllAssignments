function validate(){
	var x = document.getElementById("emailID").value;
	var atpos = x.indexOf("@");
    var dotpos = x.lastIndexOf(".");
    if (atpos<1 || dotpos<atpos+2 || dotpos+2>=x.length || isNaN(x.charAt(0))==false) {
        alert("Not a valid e-mail address. Enter a vaild E-mail ID");
    }
	else{
		alert("Valid E-mail ID");
	}
}
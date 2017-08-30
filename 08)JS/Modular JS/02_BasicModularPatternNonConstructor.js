function EmployeeList1(empId,empName,empSalary,deptNo){
	this.empId=empId;
	this.empName=empName;
	this.empSalary=empSalary;
	this.deptNo=deptNo;
}

var EmployeeList= (function(){
	var employee=[];
	return{
		addEmployee: function(e) {employee.push(e)},
		getEmployee: function() {return employee;}
	}
})();

function test()
{
	var obj1= new EmployeeList1(25,"Virat",45000,4);
	EmployeeList.addEmployee(obj1);
	var emp= EmployeeList.getEmployee();
	console.log(emp);
}


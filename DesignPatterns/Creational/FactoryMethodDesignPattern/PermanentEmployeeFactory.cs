namespace DesignPatterns.Creational.FactoryMethodDesignPattern
{
	public class PermanentEmployeeFactory : BaseEmployeeFactory
	{
		public PermanentEmployeeFactory(Employee emp) : base(emp)
		{
		}
		public override IEmployee Create()
		{
			var employee = new PermanentEmployee();
			_emp.HouseRentAllowance = employee.GetHouseRentAllowance();
			_emp.EmployeeType = EmployeeType.Permanent;
			return employee;
		}
	}
}


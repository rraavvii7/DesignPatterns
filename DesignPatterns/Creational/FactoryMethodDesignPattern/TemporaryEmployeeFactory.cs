namespace DesignPatterns.Creational.FactoryMethodDesignPattern
{
	public class TemporaryEmployeeFactory : BaseEmployeeFactory
	{
		public TemporaryEmployeeFactory(Employee emp) : base(emp)
		{
		}

        public override IEmployee Create()
        {
            var employee = new TemporaryEmployee();
            _emp.MedicalAllowance = employee.GetMedicalAllowance();
            _emp.EmployeeType = EmployeeType.Temporary;
            return employee;
        }
    }
}


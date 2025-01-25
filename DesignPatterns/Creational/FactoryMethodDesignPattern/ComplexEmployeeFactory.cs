namespace DesignPatterns.Creational.FactoryMethodDesignPattern
{
	public class ComplexEmployeeFactory
	{
		private readonly Employee _emp;

		public ComplexEmployeeFactory(Employee emp)
		{
			_emp = emp;
		}
		public BaseEmployeeFactory GetEmployeeFactory(EmployeeType employeeType)
		{
			return employeeType switch
			{
				EmployeeType.Permanent => new PermanentEmployeeFactory(_emp),
				EmployeeType.Temporary => new TemporaryEmployeeFactory(_emp),
				_ => throw new ArgumentException("Employee type does not exist.")
			};
		}
	}
}



namespace DesignPatterns.Creational.SimpleFactory
{
	public class EmployeeFactory
	{
		public IEmployee GetEmployee(EmployeeType employeeType)
		{
			return employeeType switch
			{
				EmployeeType.Permanent => new PermanentEmployee(),
				EmployeeType.Temporary => new TemporaryEmployee(),
				_ => throw new ArgumentException("Employee type is invalid")
			};
		}
	}
}


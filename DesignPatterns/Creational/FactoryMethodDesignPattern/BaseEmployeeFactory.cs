
namespace DesignPatterns.Creational.FactoryMethodDesignPattern
{
	public abstract class BaseEmployeeFactory
	{
		protected Employee _emp;
		public BaseEmployeeFactory(Employee emp)
		{
			_emp = emp;
		}
		public Employee CalculateHourlyPayAndBonus()
		{
			var employee = this.Create();
			_emp.Bonus = employee.GetBonus();
			_emp.HourlyPay = employee.GetHourlyPay();
			return _emp;
		}
		public abstract IEmployee Create();
	}
}


using DesignPatterns.Creational;

namespace DesignPatterns
{
	public class Employee
	{
		public EmployeeType EmployeeType { get; set; }

		public decimal Bonus { get; set; }

		public decimal HourlyPay { get; set; }

		// only permanent employee are eligible
		public decimal HouseRentAllowance { get; set; }

		//only temporary employee are eligible
		public decimal MedicalAllowance { get; set; }
	}
}


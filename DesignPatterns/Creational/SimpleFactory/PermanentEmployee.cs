namespace DesignPatterns.Creational.SimpleFactory
{
	public class PermanentEmployee : IEmployee
	{
		public decimal GetBonus()
		{
			return 15;
		}

		public decimal GetHourlyPay()
		{
			return 10;
		}
	}
}


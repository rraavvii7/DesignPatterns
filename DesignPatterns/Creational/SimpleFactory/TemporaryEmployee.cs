namespace DesignPatterns.Creational.SimpleFactory
{
	public class TemporaryEmployee : IEmployee
	{
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetHourlyPay()
        {
            return 8;
        }
    }
}


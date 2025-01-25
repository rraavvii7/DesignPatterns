namespace DesignPatterns.Creational.FactoryMethodDesignPattern
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

        public decimal GetMedicalAllowance()
        {
            return 3000;
        }
    }
}


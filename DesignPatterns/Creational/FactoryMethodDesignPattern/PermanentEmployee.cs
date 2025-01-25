namespace DesignPatterns.Creational.FactoryMethodDesignPattern
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

        public decimal GetHouseRentAllowance()
        {
            return 46000;
        }
    }
}


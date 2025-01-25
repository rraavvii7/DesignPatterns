namespace DesignPatterns.Creational.AbstractFactoryDesignPattern
{
	public static class EmployeeSystemManager
	{
		public static string GetSystemDetails(IComputerFactory computerFactory)
		{
			return string.Format("{0} {1} {2}",
				computerFactory.SystemType().GetSystemType(),
				computerFactory.Brand().GetBrand(),
				computerFactory.Processor().GetProcessor());
		}
	}
}


namespace DesignPatterns.Creational.AbstractFactoryDesignPattern
{
	public static class EmployeeSystemFactory
	{
		public static IComputerFactory? Create(Employee employee)
		{
			if (employee.EmployeeType == EmployeeType.Permanent)
			{
				if("Manager".Equals(employee.JobDescription, StringComparison.OrdinalIgnoreCase))
				{
					return new MacLaptopFactory();
				}
				else
				{
					return new MacFactory();
				}
			}
			else if(employee.EmployeeType == EmployeeType.Temporary)
			{
                if ("Manager".Equals(employee.JobDescription, StringComparison.OrdinalIgnoreCase))
                {
                    return new DellLaptopFactory();
                }
                else
                {
                    return new DellFactory();
                }
            }
			return null;
		}	
	}
}


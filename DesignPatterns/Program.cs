using DesignPatterns;
using DesignPatterns.Creational;
using DesignPatterns.Creational.AbstractFactoryDesignPattern;
using DesignPatterns.Creational.FactoryMethodDesignPattern;
using DesignPatterns.Creational.SimpleFactory;

// CREATIONAL DESIGN PATTERN

// Singleton

Parallel.Invoke(
    () => Singleton.Instance.DoSomething(),
    () => Singleton.Instance.DoSomething()
);
Console.WriteLine("---------------------------------------");

// Simple Factory

var factory = new EmployeeFactory();
var pEmployee = factory.GetEmployee(EmployeeType.Permanent);
var tEmployee = factory.GetEmployee(EmployeeType.Temporary);
Console.WriteLine("Employee type : {0}, Hourly Pay : {1}, Bonus : {2}", EmployeeType.Permanent, pEmployee.GetHourlyPay(), pEmployee.GetBonus());
Console.WriteLine("Employee type : {0}, Hourly Pay : {1}, Bonus : {2}", EmployeeType.Temporary, tEmployee.GetHourlyPay(), tEmployee.GetBonus());

Console.WriteLine("---------------------------------------");

// Factory method design pattern

var tempEmployee = (new ComplexEmployeeFactory(new Employee())).GetEmployeeFactory(EmployeeType.Temporary).CalculateHourlyPayAndBonus();
var permEmployee = (new ComplexEmployeeFactory(new Employee())).GetEmployeeFactory(EmployeeType.Permanent).CalculateHourlyPayAndBonus();

Console.WriteLine("Employee type : {0}, Hourly Pay : {1}, Bonus : {2}, House Rent Allownce : {3}, Medical Allowance : {4}",
    tempEmployee.EmployeeType, tempEmployee.HourlyPay, tempEmployee.Bonus, tempEmployee.HouseRentAllowance, tempEmployee.MedicalAllowance);

Console.WriteLine("Employee type : {0}, Hourly Pay : {1}, Bonus : {2}, House Rent Allownce : {3}, Medical Allowance : {4}",
    permEmployee.EmployeeType, permEmployee.HourlyPay, permEmployee.Bonus, permEmployee.HouseRentAllowance, permEmployee.MedicalAllowance);

Console.WriteLine("---------------------------------------");

// Abstract factory design pattern
var emp1 = new Employee
{
    EmployeeType = EmployeeType.Permanent,
    JobDescription = "Manager"
};
var emp2 = new Employee
{
    EmployeeType = EmployeeType.Temporary,
    JobDescription = "Developer"
};
var emp3 = new Employee
{
    EmployeeType = EmployeeType.Permanent,
    JobDescription = "Developer",
};
var emp4 = new Employee
{
    EmployeeType = EmployeeType.Temporary,
    JobDescription = "Manager"
};
var computerFactory = EmployeeSystemFactory.Create(emp1);
emp1.ComputerDetails = EmployeeSystemManager.GetSystemDetails(computerFactory!);
emp2.ComputerDetails = EmployeeSystemManager.GetSystemDetails(EmployeeSystemFactory.Create(emp2)!);
emp3.ComputerDetails = EmployeeSystemManager.GetSystemDetails(EmployeeSystemFactory.Create(emp3)!);
emp4.ComputerDetails = EmployeeSystemManager.GetSystemDetails(EmployeeSystemFactory.Create(emp4)!);

Console.WriteLine("Employee Type : {0}, Job Description : {1}, System Details : {2}", emp1.EmployeeType, emp1.JobDescription, emp1.ComputerDetails);
Console.WriteLine("Employee Type : {0}, Job Description : {1}, System Details : {2}", emp2.EmployeeType, emp2.JobDescription, emp2.ComputerDetails);
Console.WriteLine("Employee Type : {0}, Job Description : {1}, System Details : {2}", emp3.EmployeeType, emp3.JobDescription, emp3.ComputerDetails);
Console.WriteLine("Employee Type : {0}, Job Description : {1}, System Details : {2}", emp4.EmployeeType, emp4.JobDescription, emp4.ComputerDetails);

Console.WriteLine("---------------------------------------");


Console.ReadLine();
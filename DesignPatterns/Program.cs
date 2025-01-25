using DesignPatterns;
using DesignPatterns.Creational;
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

Console.ReadLine();
using System.Collections.ObjectModel;
using Employee = DesignPatterns.Employee;
using DesignPatterns.Creational;
using DesignPatterns.Creational.AbstractFactoryDesignPattern;
using DesignPatterns.Creational.BuilderDesignPattern;
using DesignPatterns.Creational.BuilderDesignPattern.ConcreteBuilder;
using DesignPatterns.Creational.BuilderDesignPattern.Director;
using DesignPatterns.Creational.FactoryMethodDesignPattern;
using DesignPatterns.Creational.FluentBuilderDesignPattern;
using DesignPatterns.Creational.SimpleFactory;
using static DesignPatterns.Creational.AbstractFactoryDesignPattern.Enumerations;
using FluentConfigurationBuilder = DesignPatterns.Creational.FluentBuilderDesignPattern.Director.ConfigurationBuilder;
using FluentBuilder = DesignPatterns.Creational.FluentBuilderDesignPattern.ConcreteBuilder;
using DesignPatterns.Creational.PrototypeDesignpattern;
using DesignPatterns.Structural.AdapterDesignPattern.Target;
using DesignPatterns.Structural.AdapterDesignPattern.Adaptor;
using DesignPatterns.Structural.BridgeDesignPattern.Abstraction;
using DesignPatterns.Structural.BridgeDesignPattern.RefinedAbstraction;
using DesignPatterns.Structural.BridgeDesignPattern.ConcreteImplementor;
using ICompositeEmployee = DesignPatterns.Structural.CompositeDesignPattern.Component.IEmployee;
using CompositeEmployee = DesignPatterns.Structural.CompositeDesignPattern.Leaf.Employee;
using DesignPatterns.Structural.CompositeDesignPattern.Composite;
using DesignPatterns.Structural.DecoratorDesignPattern.Decorator;
using DesignPatterns.Structural.DecoratorDesignPattern.ConcreteDecorator;
using DesignPatterns.Structural.DecoratorDesignPattern.Component;
using DesignPatterns.Structural.DecoratorDesignPattern.ConcreteComponent;
using DesignPatterns.Structural.FacadeDesignPattern.ShoppingFacade;
// ******************************************************* CREATIONAL DESIGN PATTERN *******************************************************

// ----------------------------------------------------------- Singleton -----------------------------------------------------------

Parallel.Invoke(
    () => Singleton.Instance.DoSomething(),
    () => Singleton.Instance.DoSomething()
);
Console.WriteLine("---------------------------------------");

// ----------------------------------------------------------- Simple Factory -----------------------------------------------------------

var factory = new EmployeeFactory();
var pEmployee = factory.GetEmployee(EmployeeType.Permanent);
var tEmployee = factory.GetEmployee(EmployeeType.Temporary);
Console.WriteLine("Employee type : {0}, Hourly Pay : {1}, Bonus : {2}", EmployeeType.Permanent, pEmployee.GetHourlyPay(), pEmployee.GetBonus());
Console.WriteLine("Employee type : {0}, Hourly Pay : {1}, Bonus : {2}", EmployeeType.Temporary, tEmployee.GetHourlyPay(), tEmployee.GetBonus());

Console.WriteLine("---------------------------------------");

// ----------------------------------------------------------- Factory method design pattern -----------------------------------------------------------

var tempEmployee = (new ComplexEmployeeFactory(new Employee())).GetEmployeeFactory(EmployeeType.Temporary).CalculateHourlyPayAndBonus();
var permEmployee = (new ComplexEmployeeFactory(new Employee())).GetEmployeeFactory(EmployeeType.Permanent).CalculateHourlyPayAndBonus();

Console.WriteLine("Employee type : {0}, Hourly Pay : {1}, Bonus : {2}, House Rent Allownce : {3}, Medical Allowance : {4}",
    tempEmployee.EmployeeType, tempEmployee.HourlyPay, tempEmployee.Bonus, tempEmployee.HouseRentAllowance, tempEmployee.MedicalAllowance);

Console.WriteLine("Employee type : {0}, Hourly Pay : {1}, Bonus : {2}, House Rent Allownce : {3}, Medical Allowance : {4}",
    permEmployee.EmployeeType, permEmployee.HourlyPay, permEmployee.Bonus, permEmployee.HouseRentAllowance, permEmployee.MedicalAllowance);

Console.WriteLine("---------------------------------------");

// ----------------------------------------------------------- Abstract factory design pattern -----------------------------------------------------------

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

// ----------------------------------------------------------- Builder design pattern -----------------------------------------------------------

var employees = new List<Employee>
{
    emp1,emp2,emp3,emp4
};
ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
foreach (var employee in employees)
{
    if (employee.ComputerDetails.Contains(ComputerType.Laptop.ToString()))
    {
        IBuilder laptopBuilder = new LaptopBuilder();
        configurationBuilder.BuildSystem(laptopBuilder, new ReadOnlyDictionary<string, string>
            (
                new Dictionary<string, string>
                {
                    { "RAM", "8"},
                    { "HDD", "500 GB"},
                    { "Touchscreen", "Enabled" },
                }
            ));
        var systemDetails = laptopBuilder.GetSystem();
        employee.SystemConfigurationDetails = string.Format("RAM : {0}, HDD : {1}, Touchscreen : {2} ", systemDetails.RAM, systemDetails.HDD, systemDetails.TouchScreen);
    }
    else if (employee.ComputerDetails.Contains(ComputerType.Desktop.ToString()))
    {
        IBuilder desktopBuilder = new DesktopBuilder();
        configurationBuilder.BuildSystem(desktopBuilder, new ReadOnlyDictionary<string, string>
           (
               new Dictionary<string, string>
               {
                    { "RAM", "16"},
                    { "HDD", "1 TB"},
                    { "KeyboardType", "Wireless" },
                    { "MouseType", "Wireless" },
               }
           ));
        var systemDetails = desktopBuilder.GetSystem();
        employee.SystemConfigurationDetails = string.Format("RAM : {0}, HDD : {1}, Keyboard : {2}, Mouse : {3} ", systemDetails.RAM, systemDetails.HDD, systemDetails.Keyboard, systemDetails.Mouse);
    }
}
foreach (var employee in employees)
{
    Console.WriteLine("Employee Type : {0}, Job Description : {1}, System Details : {2}, System Configuration : {3}",
        employee.EmployeeType, employee.JobDescription, employee.ComputerDetails, employee.SystemConfigurationDetails);
}
Console.WriteLine("---------------------------------------");

// ----------------------------------------------------------- Fluent Builder Design Pattern -----------------------------------------------------------

employees.ForEach(e => e.SystemConfigurationDetails = string.Empty);
employees.ForEach(e => Console.WriteLine(e.SystemConfigurationDetails+ "No system configuration detail found for "+ e.ToString()));
Console.WriteLine("\nNow assigning system configuration details through fluent design pattern \n");

FluentConfigurationBuilder fluentConfigurationBuilder = new FluentConfigurationBuilder();
foreach (var employee in employees)
{
    if (employee.ComputerDetails.Contains(ComputerType.Laptop.ToString()))
    {
        IFluentBuilder laptopBuilder = new FluentBuilder.LaptopBuilder();
        fluentConfigurationBuilder.BuildSystem(laptopBuilder, new ReadOnlyDictionary<string, string>
            (
                new Dictionary<string, string>
                {
                    { "RAM", "8"},
                    { "HDD", "500 GB"},
                    { "Touchscreen", "Enabled" },
                }
            ));
        var systemDetails = laptopBuilder.GetSystem();
        employee.SystemConfigurationDetails = string.Format("RAM : {0}, HDD : {1}, Touchscreen : {2} ", systemDetails.RAM, systemDetails.HDD, systemDetails.TouchScreen);
    }
    else if (employee.ComputerDetails.Contains(ComputerType.Desktop.ToString()))
    {
        IFluentBuilder desktopBuilder = new FluentBuilder.DesktopBuilder();
        fluentConfigurationBuilder.BuildSystem(desktopBuilder, new ReadOnlyDictionary<string, string>
           (
               new Dictionary<string, string>
               {
                    { "RAM", "16"},
                    { "HDD", "1 TB"},
                    { "KeyboardType", "Wireless" },
                    { "MouseType", "Wireless" },
               }
           ));
        var systemDetails = desktopBuilder.GetSystem();
        employee.SystemConfigurationDetails = string.Format("RAM : {0}, HDD : {1}, Keyboard : {2}, Mouse : {3} ", systemDetails.RAM, systemDetails.HDD, systemDetails.Keyboard, systemDetails.Mouse);
    }
}
foreach (var employee in employees)
{
    Console.WriteLine("Employee Type : {0}, Job Description : {1}, System Details : {2}, System Configuration : {3}",
        employee.EmployeeType, employee.JobDescription, employee.ComputerDetails, employee.SystemConfigurationDetails);
}
Console.WriteLine("---------------------------------------");

// ----------------------------------------------------------- Prototype Design Pattern -----------------------------------------------------------

Helper.PrototypeClone();

Console.WriteLine("---------------------------------------");


// ******************************************************* STRUCTURAL DESIGN PATTERN *******************************************************

// ----------------------------------------------------------- Adaptor Design Pattern -----------------------------------------------------------

ICompany company = new CompanyAdaptor();
var jsonValues = company.GetAllCompanies();
Console.WriteLine(jsonValues);

Console.WriteLine("---------------------------------------");

// ----------------------------------------------------------- Bridge design pattern -----------------------------------------------------------

// depending on the end customer choice one can select card payment or net banking payment
Payment order = new CardPayment();

// depending on the availability of payment gateway (logic) one can choose citibank payment gateway or idbi payment gateway
order.paymentSystem = new CitibankPaymentSystem();

order.MakePayment();

order.paymentSystem = new IDBIPaymentSystem();
order.MakePayment();

order = new NetbankingPayment();
order.paymentSystem = new CitibankPaymentSystem();
order.MakePayment();

order.paymentSystem = new IDBIPaymentSystem();
order.MakePayment();

Console.WriteLine("---------------------------------------");


// ----------------------------------------------------------- Composite design pattern -----------------------------------------------------------

// leaf
ICompositeEmployee John = new CompositeEmployee("John", "HR");
ICompositeEmployee Mary = new CompositeEmployee("Mary", "HR");
ICompositeEmployee Sam = new CompositeEmployee("Sam", "HR");

ICompositeEmployee Andrew = new CompositeEmployee("Andrew", "IT");
ICompositeEmployee Scott = new CompositeEmployee("Scott", "IT");

// composite
ICompositeEmployee Sarath = new Manager("Sarath", "IT")
{
    SubOrdinates = new List<ICompositeEmployee> { Andrew, Scott }
};
ICompositeEmployee Vishal = new Manager("Vishal", "HR")
{
    SubOrdinates = new List<ICompositeEmployee> { John, Mary, Sam }
};


ICompositeEmployee Ranjan = new Manager("Ranjan", "Head")
{
    SubOrdinates = new List<ICompositeEmployee> { Sarath, Vishal }
};

Ranjan.GetDetails(1);
Console.WriteLine("---------------------------------------");

//----------------------------------------------------------- Decorator design pattern -----------------------------------------------------------
ICar suzuki = new Suzuki();
CarDecorator carDecorator = new OfferPrice(suzuki);
Console.WriteLine(string.Format("Car Name : {0}, Price : {1}, Discounted Price : {2}", carDecorator.Make, carDecorator.GetPrice(), carDecorator.GetDiscountedPrice(0.8)));

var hyundai = new Hyndai();
carDecorator = new OfferPrice(hyundai);
Console.WriteLine(string.Format("Car Name : {0}, Price : {1}, Discounted Price : {2}", carDecorator.Make, carDecorator.GetPrice(), carDecorator.GetDiscountedPrice(0.7)));
Console.WriteLine("---------------------------------------");
 

//----------------------------------------------------------- Facade design pattern -----------------------------------------------------------
IUserOrder userOrder = new UserOrder();
Console.WriteLine("Facade : Start");
Console.WriteLine("************************************");
int cartID = userOrder.AddToCart(10, 1);
int userID = 1234;
Console.WriteLine("************************************");
int orderID = userOrder.PlaceOrder(cartID, userID);
Console.WriteLine("************************************");
Console.WriteLine("Facade : End CartID = {0}, OrderID = {1}",cartID, orderID);

Console.WriteLine("---------------------------------------");
Console.ReadLine();
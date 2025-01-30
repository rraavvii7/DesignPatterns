
namespace DesignPatterns.Creational.PrototypeDesignpattern
{
    public static class Helper
    {
        public static void ShallowCopy()
        {
            Employee John = new()
            {
                ID = "1",
                Name = "John",
                DepartmentID = " IT"
            };

            Console.WriteLine(John.ToString());
            Employee Sam = (Employee)John.Clone();
            Sam.Name = "Sam";
            Console.WriteLine(Sam.ToString());
            Console.WriteLine("change John department to CSE");
            John.DepartmentID = "CSE";
            Console.WriteLine(John.ToString());
            Console.WriteLine(Sam.ToString());
        }

        public static void ShallowCopyRef()
        {
            Employee John = new()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "John",
                DepartmentID = " IT",
                AddressDetails = new Address
                {
                    HouseNumber = "302",
                    Area = "Sarjapur Main Road",
                    City = "Bangalore",
                    ZipCode = "560035"
                }
            };

            Console.WriteLine(John.ToString());
            Employee Sam = (Employee)John.Clone();
            Sam.Name = "Sam";
            Console.WriteLine(Sam.ToString());
        }
    }
}

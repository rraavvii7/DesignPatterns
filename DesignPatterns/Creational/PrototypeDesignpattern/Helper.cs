
namespace DesignPatterns.Creational.PrototypeDesignpattern
{
    public static class Helper
    {
        public static void PrototypeClone()
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

            // shallow copy
            // uncomment the below lines to understand shallow copy and comment deep copy

            //Console.WriteLine(John.ToString());
            //Employee Sam = (Employee)John.Clone();
            //Sam.Name = "Sam";
            //Console.WriteLine(Sam.ToString());



            // deep copy
            // uncomment the below lines to understand deep copy and comment shallow copy

            Console.WriteLine(John.ToString());
            Employee Sam = (Employee)John.DeepCopy()!;
            Sam.Name = "Sam";
            Console.WriteLine(Sam.ToString());

            Sam.AddressDetails.HouseNumber = "11";
            Sam.AddressDetails.ZipCode = "853204";
            Sam.AddressDetails.Area = "Naugachia";
            Sam.AddressDetails.City = "Bhagalpur";
            Console.WriteLine(Sam.ToString());

            Console.WriteLine("modified details of John");
            John.AddressDetails.ZipCode = "560037";
            John.AddressDetails.Area = "Marathalli";
            John.DepartmentID = "Electronics";
            Console.WriteLine(John.ToString());
            Console.WriteLine(Sam.ToString());
        }
    }
}

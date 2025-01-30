
namespace DesignPatterns.Creational.PrototypeDesignpattern
{
    public partial class Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string DepartmentID { get; set; }
        public override string ToString()
        {
            return string.Format("ID : {0}, Name : {1}, DepartmentID : {2}, Address : {3}", ID, Name, DepartmentID, AddressDetails?.ToString());
        }
    }

    public partial class Employee : ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public partial class Employee
    {
        public Address AddressDetails { get; set; }
    }

    public class Address
    {
        public string HouseNumber { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public override string ToString()
        {
            return string.Format("House Number : {0}, Area : {1}, City : {2}, ZipCode : {3}", HouseNumber, Area, City, ZipCode); ;
        }
    }
}


using DesignPatterns.Structural.CompositeDesignPattern.Component;

namespace DesignPatterns.Structural.CompositeDesignPattern.Leaf
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Employee(string name, string department)
        {
            Name = name;
            Department = department;
        }
        public void GetDetails(int indentation)
        {
            Console.WriteLine(string.Format("{0} Name : {1}, Department : {2}", new String('-', indentation), Name, Department));
        }
    }
}

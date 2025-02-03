
using DesignPatterns.Structural.CompositeDesignPattern.Component;

namespace DesignPatterns.Structural.CompositeDesignPattern.Composite
{
    public class Manager : IEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public List<IEmployee> SubOrdinates { get; set; }
        public Manager(string name, string department)
        {
            Name = name;
            Department = department;
            SubOrdinates = new();
        }
        public void GetDetails(int indentation)
        {
            Console.WriteLine();
            Console.WriteLine(string.Format("{0} Name : {1}, Department : {2}", new String('-', indentation), Name, Department));
            foreach(var emp in SubOrdinates)
            {
                emp.GetDetails(indentation + 1);
            }
        }
        
    }
}

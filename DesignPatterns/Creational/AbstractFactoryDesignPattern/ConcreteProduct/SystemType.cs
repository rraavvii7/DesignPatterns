using static DesignPatterns.Creational.AbstractFactoryDesignPattern.Enumerations;

namespace DesignPatterns.Creational.AbstractFactoryDesignPattern
{

    public class Laptop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerType.Laptop.ToString();

        }
    }

    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerType.Desktop.ToString();

        }
    }

}


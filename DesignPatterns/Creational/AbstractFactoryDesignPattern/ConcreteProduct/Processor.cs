
using static DesignPatterns.Creational.AbstractFactoryDesignPattern.Enumerations;

namespace DesignPatterns.Creational.AbstractFactoryDesignPattern
{
    public class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return Processor.I7.ToString();
        }
    }

    public class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return Processor.I5.ToString();
        }
    }
}


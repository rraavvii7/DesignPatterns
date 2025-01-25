using static DesignPatterns.Creational.AbstractFactoryDesignPattern.Enumerations;

namespace DesignPatterns.Creational.AbstractFactoryDesignPattern
{
    public class MAC : IBrand
    {
        public string GetBrand()
        {
            return Brand.APPLE.ToString();
        }
    }

    public class DELL : IBrand
    {
        public string GetBrand()
        {
            return Brand.DELL.ToString();
        }
    }
}


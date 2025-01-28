
using DesignPatterns.Creational.BuilderDesignPattern.Product;

namespace DesignPatterns.Creational.BuilderDesignPattern.ConcreteBuilder
{
    public class LaptopBuilder : IBuilder
    {
        private ComputerSystem _laptop = new ComputerSystem();

        public void AddHDD(string size)
        {
            _laptop.HDD = size;
        }

        public void AddKeyboard(string type)
        {
            return;
        }

        public void AddMemory(string size)
        {
            _laptop.RAM = size;
        }

        public void AddMouse(string type)
        {
            return;
        }

        public void AddTouchscreen(string enabled)
        {
            _laptop.TouchScreen = enabled;
        }

        public ComputerSystem GetSystem()
        {
            return _laptop;
        }
    }
}

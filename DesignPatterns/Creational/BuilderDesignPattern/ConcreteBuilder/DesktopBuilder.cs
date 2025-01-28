
using DesignPatterns.Creational.BuilderDesignPattern.Product;

namespace DesignPatterns.Creational.BuilderDesignPattern.ConcreteBuilder
{
    public class DesktopBuilder : IBuilder
    {
        private ComputerSystem _desktop = new ComputerSystem();

        public void AddHDD(string size)
        {
            _desktop.HDD = size;
        }

        public void AddKeyboard(string type)
        {
           _desktop.Keyboard = type;
        }

        public void AddMemory(string size)
        {
            _desktop.RAM = size;
        }

        public void AddMouse(string type)
        {
            _desktop.Mouse = type;
        }

        public void AddTouchscreen(string enabled)
        {
            return;
        }

        public ComputerSystem GetSystem()
        {
            return _desktop;
        }
    }
}

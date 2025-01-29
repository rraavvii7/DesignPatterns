using DesignPatterns.Creational.FluentBuilderDesignPattern.Product;

namespace DesignPatterns.Creational.FluentBuilderDesignPattern.ConcreteBuilder
{
	public class DesktopBuilder : IFluentBuilder
	{
        private ComputerSystem _desktop = new ComputerSystem();

        public IFluentBuilder AddHDD(string size)
        {
            _desktop.HDD = size;
            return this;
        }

        public IFluentBuilder AddKeyboard(string type)
        {
            _desktop.Keyboard = type;
            return this;
        }

        public IFluentBuilder AddMemory(string size)
        {
            _desktop.RAM = size;
            return this;
        }

        public IFluentBuilder AddMouse(string type)
        {
            _desktop.Mouse = type;
            return this;
        }

        public IFluentBuilder AddTouchscreen(string enabled)
        {
            return this;
        }

        public ComputerSystem GetSystem()
        {
            return _desktop;
        }
    }
}


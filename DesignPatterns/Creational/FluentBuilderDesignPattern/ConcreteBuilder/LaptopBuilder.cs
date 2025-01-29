
using DesignPatterns.Creational.FluentBuilderDesignPattern.Product;

namespace DesignPatterns.Creational.FluentBuilderDesignPattern.ConcreteBuilder
{
	public class LaptopBuilder : IFluentBuilder
	{
        private ComputerSystem _laptop = new ComputerSystem();

        public IFluentBuilder AddHDD(string size)
        {
            _laptop.HDD = size;
            return this;
        }

        public IFluentBuilder AddKeyboard(string type)
        {
            return this;
        }

        public IFluentBuilder AddMemory(string size)
        {
            _laptop.RAM = size;
            return this;
        }

        public IFluentBuilder AddMouse(string type)
        {
            return this;
        }

        public IFluentBuilder AddTouchscreen(string enabled)
        {
            _laptop.TouchScreen = enabled;
            return this;
        }

        public ComputerSystem GetSystem()
        {
            return _laptop;
        }
    }
}


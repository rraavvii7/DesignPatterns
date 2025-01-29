
using DesignPatterns.Creational.FluentBuilderDesignPattern.Product;

namespace DesignPatterns.Creational.FluentBuilderDesignPattern
{
	public interface IFluentBuilder
	{
        //common
        IFluentBuilder AddMemory(string size);
        IFluentBuilder AddHDD(string size);

        //for desktop
        IFluentBuilder AddKeyboard(string type);
        IFluentBuilder AddMouse(string type);

        //for laptop
        IFluentBuilder AddTouchscreen(string enabled);

        ComputerSystem GetSystem();
    }
}


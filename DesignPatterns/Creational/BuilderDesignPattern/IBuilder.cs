
using DesignPatterns.Creational.BuilderDesignPattern.Product;

namespace DesignPatterns.Creational.BuilderDesignPattern
{
    public interface IBuilder
    {
        void AddMemory(string size);
        void AddHDD(string size);

        //for desktop
        void AddKeyboard(string type);
        void AddMouse(string type);

        //for laptop
        void AddTouchscreen(string enabled);

        ComputerSystem GetSystem();
    }
}

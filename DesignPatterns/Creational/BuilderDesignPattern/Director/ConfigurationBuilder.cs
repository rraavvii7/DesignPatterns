
using System.Collections.ObjectModel;

namespace DesignPatterns.Creational.BuilderDesignPattern.Director
{
    public class ConfigurationBuilder
    {
        public void BuildSystem(IBuilder builder, ReadOnlyDictionary<string, string> collection)
        {
            builder.AddHDD(collection["HDD"]);
            builder.AddMemory(collection["RAM"]);
            builder.AddTouchscreen(collection["Touchscreen"]);
            builder.AddKeyboard(collection["KeyboardType"]);
            builder.AddMouse(collection["MouseType"]);
        }
    }
}

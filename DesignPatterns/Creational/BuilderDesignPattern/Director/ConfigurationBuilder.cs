
using System.Collections.ObjectModel;

namespace DesignPatterns.Creational.BuilderDesignPattern.Director
{
    public class ConfigurationBuilder
    {
        public void BuildSystem(IBuilder builder, ReadOnlyDictionary<string, string> collection)
        {
            builder.AddHDD(collection.GetValueOrDefault("HDD", string.Empty));
            builder.AddMemory(collection.GetValueOrDefault("RAM", string.Empty));
            builder.AddTouchscreen(collection.GetValueOrDefault("Touchscreen", string.Empty));
            builder.AddKeyboard(collection.GetValueOrDefault("KeyboardType", string.Empty));
            builder.AddMouse(collection.GetValueOrDefault("MouseType", string.Empty));
        }
    }
}

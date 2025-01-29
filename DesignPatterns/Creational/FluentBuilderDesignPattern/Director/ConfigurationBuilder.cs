using System.Collections.ObjectModel;

namespace DesignPatterns.Creational.FluentBuilderDesignPattern.Director
{
	public class ConfigurationBuilder
	{
        public void BuildSystem(IFluentBuilder builder, ReadOnlyDictionary<string, string> collection)
        {
            builder.AddHDD(collection.GetValueOrDefault("HDD", string.Empty))
                   .AddMemory(collection.GetValueOrDefault("RAM", string.Empty))
                   .AddTouchscreen(collection.GetValueOrDefault("Touchscreen", string.Empty))
                   .AddKeyboard(collection.GetValueOrDefault("KeyboardType", string.Empty))
                   .AddMouse(collection.GetValueOrDefault("MouseType", string.Empty));
        }
    }
}


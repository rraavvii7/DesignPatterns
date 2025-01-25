namespace DesignPatterns.Creational.AbstractFactoryDesignPattern
{
	public interface IComputerFactory
	{
		ISystemType SystemType();
		IBrand Brand();
		IProcessor Processor();
	}
}


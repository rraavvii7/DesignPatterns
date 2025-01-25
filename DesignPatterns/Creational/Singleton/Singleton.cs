namespace DesignPatterns.Creational
{
	public sealed class Singleton
	{
        // Lazy initialization with thread-safety guaranteed.
        private static readonly Lazy<Singleton> _lazyInstance = new Lazy<Singleton>(() => new Singleton());

        private static int counter;

        // Private constructor to prevent instantiation from outside.
        private Singleton()
        {
            counter++;
            Console.WriteLine("Singleton Instance Created. Count {0}", counter);
        }

        // Public property to access the Singleton instance.
        public static Singleton Instance => _lazyInstance.Value;

        // Example method in the Singleton class.
        public void DoSomething()
        {
            Console.WriteLine("Singleton method executed.");
        }

    }
}


namespace ConsoleApp1
{
	public abstract class Animal
	{
		public abstract string Name { get; }

		public abstract void MakeSounds();

		public abstract void GetSpeed();

		public void Sleep()
		{
			System.Console.WriteLine("I am sleeping... Sh-h-h...");
		}
	}
}

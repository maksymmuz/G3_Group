using System;

namespace ConsoleApp1
{
	class Dog : Animal
	{
		public override string Name => "I am a dog";

		public override void GetSpeed()
		{
			Console.WriteLine("I run at 40 kilometers per hour");
		}

		public override void MakeSounds()
		{
			Console.WriteLine("Woof!");
		}

		public void ServePeople()
		{
			Console.WriteLine("I can be a friend and bodyguard");
		}
	}
}

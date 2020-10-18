using System;

namespace ConsoleApp1
{
	sealed class  Horse : Animal, IServePeople
	{		 

		public sealed override string Name => "I am a Horse";

		public sealed override void GetSpeed()
		{
			Console.WriteLine("I run at 30 kilometers per hour");
		}

		public override void MakeSounds()
		{
			Console.WriteLine("I-go-go!");
		}

		public void ServePeople()
		{
			Console.WriteLine("I can carry goods on myself");
		}
	}
}

using NUnit.Framework;

namespace JenkinsProject
{
	public class UnitTest1
	{
		// C:\Users\Maksym\AppData\Local\Jenkins\.jenkins\workspace\Selenium_G3
		[Test]
		public void TestMethod1()
		{
			System.Console.WriteLine("1. For testing Run from Jenkins");
		}

		[Test]
		public void TestMethod2()
		{
			Assert.IsTrue(false);
			System.Console.WriteLine("2. For testing Run from Jenkins");
		}
	}
}

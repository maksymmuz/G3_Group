using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Configuration;
using System.Threading;
using System.IO;

namespace WebDriverG3
{
	class UploadFile
	{
		IWebDriver driver;

		//[SetUp]
		//public void SetUp()
		//{
		//	string url = "http://demo.guru99.com/test/upload/";
		//	driver = new ChromeDriver();
		//	driver.Manage().Window.Maximize();
		//	driver.Navigate().GoToUrl(url);
		//	driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
		//}

		//[TearDown]
		//public void TearDown()
		//{
		//	driver.Quit();
		//}

		[Test]
		public void UploadFileTest()
		{
			string expectedValue = @"C:\fakepath\DataBase.png";
			string pathToFile = "C:/Users/Maksym/Desktop/Project/DataBase.png";
			IWebElement element = driver.FindElement(By.Id("uploadfile_0"));
			element.SendKeys(pathToFile);
			string actualValue = element.GetProperty("value");

			new Actions(driver).SendKeys(Keys.Control).SendKeys("v").SendKeys(Keys.Enter).Perform();

			Assert.AreEqual(expectedValue, actualValue, "Some message if test fail.");
		}

		[Test]
		public void UploadFileTest1()
		{
			string expectedValue = @"C:\fakepath\DataBase.png";
			string pathToFile = "C:/Users/Maksym/Desktop/Project/DataBase.png";
			IWebElement element = driver.FindElement(By.Id("file_wraper0"));
			
			element.Click();
			Thread.Sleep(2000);
			new Actions(driver).SendKeys(Keys.Control).SendKeys("V").SendKeys(Keys.Enter).Perform();
			string actualValue = element.GetProperty("value");			

			Assert.AreEqual(expectedValue, actualValue, "Some message if test fail.");
		}

		[Test]
		public void UploadFileTest2()
		{
			string testData1 = ConfigurationManager.AppSettings["testData"];
			string testData2 = ConfigurationManager.AppSettings["anotherData"];

			Console.WriteLine(testData1);
			Console.WriteLine(testData2);

			string text = File.ReadAllText(@"C:\Users\Maksym\Desktop\new5.txt");
			Console.WriteLine(text);

			string[] lines = File.ReadAllLines(@"C:\Users\Maksym\Desktop\new5.txt");
			foreach (string line in lines)
			{
				Console.WriteLine("\n\t" + line);
			}

			Assert.AreEqual(1, 1, "Some message if test fail.");
		}
	}
}

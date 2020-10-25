using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace WebDriverG3
{
	class LogInTest
	{
		public IWebDriver driver;

		[SetUp]
		public void Setup()
		{
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl("https://www.facebook.com/");
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
		}

		[TearDown]
		public void TearDown()
		{
			driver.Quit();
		}

		//[Test]
		//public void LogInTestCorrectData()
		//{
		//	string userLogin = "troian.kateryna";
		//	string userPass = "SomePass123";

		//	LogInAsUser loginTo = new LogInAsUser(driver);
		//	loginTo.SetName(userLogin);
		//	loginTo.SetPass(userPass);

		//	Thread.Sleep(2000);
		//}

		[Test]
		public void LogInTestCorrectData1()
		{
			string userLogin = "troian.kateryna";
			string userPass = "SomePass123";

			LogInAsUser loginTo = new LogInAsUser(driver);
			loginTo.LogInActions(userLogin, userPass);

			Thread.Sleep(2000);
		}
	}
}

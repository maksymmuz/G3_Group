using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WebDriver321
{
	public class UiTests
	{
		IWebDriver driver;

		[SetUp]
		public void Setup()
		{
			driver = new ChromeDriver();
		}

		[TearDown]
		public void TearDown()
		{
			driver.Quit();
		}

		[Test]
		public void Test1()
		{
			string currentWindowHandle = driver.CurrentWindowHandle;
			var windowHandles = driver.WindowHandles;

			

			IWebElement webElement = driver.FindElement(By.CssSelector("cssSelector"));
			



			Console.WriteLine(currentWindowHandle);
		}
	}
}

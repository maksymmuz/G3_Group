using EtsyAutomationTests.Pages;
using G3_AutomationFramework.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace EtsyAutomationTests.Tests
{
	public class EtsyTests
	{
		IWebDriver driver;

		[SetUp]
		public void Setup()
		{
			driver = new ChromeDriver();
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
			driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl("https://www.etsy.com/");
		}

		[TearDown]
		public void TearDown()
		{
			driver.Quit();
		}

		[Test]
		public void SearchTest()
		{
			string searchText = "Sweater";
			EtsyMainPage etsyMainPage = new EtsyMainPage(driver);
			// wrong approach
			etsyMainPage.searchArea.searchField.SendKeys(searchText);
			// go to WebElementExtensions
			//etsyMainPage.searchArea.searchField.SetText("sweater");
			etsyMainPage.searchArea.searchButton.Click();

			EtsySearchPage etsySearchPage = new EtsySearchPage(driver);

			foreach (var item in etsySearchPage.foundTextItemList)
			{
				Console.WriteLine(item.Text.Trim());
				Assert.IsTrue((item.Text.Trim()).Contains(searchText), $"Item with text {item.Text} doesn'n contain search text {searchText}");
			}


			Thread.Sleep(2000);
		}
	}
}

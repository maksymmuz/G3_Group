using EtsyAutomationTests.Pages;
using G3_AutomationFramework.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
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
			string searchText = "sweater";

			EtsyMainPage etsyMainPage = new EtsyMainPage(driver);

			etsyMainPage.SearchArea.searchField.SendKeys(searchText);
			etsyMainPage.SearchArea.searchButton.Click();

			EtsySearchPage etsySearchPage = new EtsySearchPage(driver);

			//List<string> texts = new List<string>();

			//foreach (var item in etsySearchPage.foundTextItemList)
			//{
			//	texts.Add(item.Text);
			//}


			// wrong approach
			//etsyMainPage.searchArea.searchField.SendKeys(searchText);
			// go to WebElementExtensions
			//etsyMainPage.searchArea.searchField.SetText("sweater");
			//etsyMainPage.searchArea.searchButton.Click();


			foreach (var item in etsySearchPage.foundTextItemList)
			{
				Console.WriteLine(item.Text);
				Assert.IsTrue(item.Text.ToLower().Contains(searchText),
					$"Item with text {item.Text} doesn'n contain search text {searchText}");
			}

			Thread.Sleep(2000);
		}
	}
}

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace WebDriverG3
{
	class TestingActions
	{
		[Test]
		public void TestingActionsAndAction()
		{
			IWebDriver driver = null;

			Actions action = new Actions(driver);

			action.Click();
		}
	}
}

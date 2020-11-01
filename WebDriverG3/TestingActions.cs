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
			IWebElement someElement = null;
			IWebElement sourse = null;
			IWebElement target = null;

			Actions action = new Actions(driver);

			IAction sequence = action.MoveToElement(someElement).KeyDown(Keys.Control).KeyDown("A")
				.KeyDown(Keys.Delete).KeyUp("A").KeyUp(Keys.Control).Build();

			
			action.MoveToElement(sourse).ClickAndHold().MoveToElement(target).Release().Perform();
		}
	}
}

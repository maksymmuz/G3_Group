using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;

namespace Waits
{
	public static class WebDriverExtansions
	{
		public static void TakeScreenshot(this IWebDriver driver, string path)
		{
			var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
			screenshot.SaveAsFile(Path.Combine("First part of path", path)); // Path.Combine
		}

		public static void JavaScriptClick(this IWebDriver driver, IWebElement control)
		{
			((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", control);
		}

		public static void OpenAndSwitchToNewWindow(this IWebDriver driver)
		{
			var parentHendles = driver.WindowHandles;
			((IJavaScriptExecutor)driver).ExecuteScript("window.open();"); // window.open(); 

			var allHendles = driver.WindowHandles;

			foreach (var hendle in allHendles)
			{
				if (!parentHendles.Contains(hendle))
				{
					driver.SwitchTo().Window(hendle);
				}
			}
		}

		public static void SetTextUsingActions(this IWebDriver driver, string text)
		{
			new Actions(driver).SendKeys(text).Perform();
		}

		//click "clikable" element
		public static void ClickWebElement(this IWebDriver driver, IReadOnlyCollection<IWebElement> webItems, int delay)
		{
			foreach (var item in webItems)
			{
				try
				{
					CustomWaits.WaitForElementIsClickable(driver, item, delay);
					item.Click();
				}
				catch (WebDriverTimeoutException)
				{
				}
			}
		}

		public static void DragAndDrop(this IWebDriver driver, IWebElement sourceElement, IWebElement targetElement)
		{
			new Actions(driver).ClickAndHold(sourceElement).MoveToElement(targetElement).Release().Perform();
		}

		public static void SetImplicitWait(this IWebDriver driver, int timeout)
		{
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
		}

		public static void ExplicitWaitUntil<TResult>(this IWebDriver driver, Func<IWebDriver, TResult> condition, int timeout = 5, Type TWebDriverException = null)
		{
			var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
			if (TWebDriverException != null)
			{
				wait.IgnoreExceptionTypes(TWebDriverException);
			}
			wait.Until(condition);
		}
	}
}

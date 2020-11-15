using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace Waits
{
	public static class CustomWaits
	{
		public static void WaitForDataLoadingInAccommodation(IWebDriver driver)
		{
			driver.SetImplicitWait(1);
			var locator = By.CssSelector("Some cssSelector");

			driver.ExplicitWaitUntil(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(locator));
			driver.SetImplicitWait(10);
		}

		public static void WaitForDataLoadingInAdmission(IWebDriver driver)
		{
			driver.ExplicitWaitUntil(e => e.FindElements(By.Id("Some Selector eith Id")));
		}

		public static void WaitForElementIsClickable(IWebDriver driver, IWebElement element, int timeout)
		{
			driver.ExplicitWaitUntil(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element), timeout);
		}

		public static void WaitForElementExist(IWebDriver driver, By locator, int timeout)
		{
			driver.ExplicitWaitUntil(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator), timeout);
		}

		public static void WaitForElementNotExist(IWebDriver driver, By locator)
		{
			Func<IWebDriver, bool> isElementNotPresent = (webDriver) =>
			{
				try
				{
					driver.FindElement(locator);
				}
				catch (Exception ex)
				{
					return true;
				}
				return false;
			};
			driver.ExplicitWaitUntil(isElementNotPresent);
		}

		public static void WaitForAlert(IWebDriver driver)
		{
			driver.ExplicitWaitUntil(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
		}

		public static void WaitForDropdownFilterApplied(IWebDriver driver, IWebElement dropdown, string expectedItemXPath, string dropdownItemXPath)
		{
			driver.ExplicitWaitUntil(webDriwer => webDriwer.FindElements(By.XPath(dropdownItemXPath)).Count == 1
			&& webDriwer.FindElement(By.XPath(expectedItemXPath)).Displayed);
			dropdown.SendKeys(Keys.Enter);
		}

		public static void WaitForElementIsDisplayed(IWebElement element, int timeout = 3, double pollingInterval = 1)
		{
			var wait = CreateDefaultWait(element, timeout, pollingInterval);
			wait.Until(webElement => webElement != null && webElement.Displayed);
		}

		public static void WaitForElementIsEnabled(IWebElement element, int timeout = 3, double pollingInterval = 1)
		{
			var wait = CreateDefaultWait(element, timeout, pollingInterval);
			wait.Until(webElement => webElement != null && webElement.Enabled);
		}

		public static void WaitForClickElement(IWebElement control, int timeout = 5, int repeatActionInterval = 1)
		{
			var wait = CreateDefaultWait(control, timeout, repeatActionInterval);
			wait.IgnoreExceptionTypes(typeof(Exception));
			Func<IWebElement, bool> isElementClicked = (webElement) =>
			{
				if (webElement.Displayed)
				{
					try
					{
						webElement.Click();
						return true;
					}
					catch (Exception)
					{
						return false;
					}
				}
				return false;
			};
			wait.Until(isElementClicked);
		}

		public static void WaitForWebElementAttribute(IWebElement control, string attributeName, string expectedValue, int timeout, int repeatActionInterval)
		{
			var wait = CreateDefaultWait(control, timeout, repeatActionInterval);
			Func<IWebElement, bool> isElementHasAttribute = (webElement) =>
			{
				if (webElement.GetAttribute(attributeName) == expectedValue)
				{
					return true;
				}
				return false;
			};
			wait.Until(isElementHasAttribute);
		}

		public static DefaultWait<T> CreateDefaultWait<T>(T element, int timeout, double pollingInterval)
		{
			var wait = new DefaultWait<T>(element)
			{
				Timeout = TimeSpan.FromSeconds(timeout),
				PollingInterval = TimeSpan.FromSeconds(pollingInterval)
			};
			return wait;
		}
	}
}

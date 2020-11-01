using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace G3_AutomationFramework.Utils
{
	public static class WebElementExtensions
	{
		public static void SetText(/*this*/ IWebElement element, string text)
		{
			element.SendKeys(text);
		}

		// example work with extansion
		//public static void TestSetText(IWebDriver driver, string locator, string text)
		//{
		//	IWebElement el = driver.FindElement(By.CssSelector(locator));
		//}








		//public static void SetText(this IWebElement element, string text)
		//{
		//	element.SendKeys(text);
		//}

		//public static void SetDropDownOptionByText(this IWebElement element, string text)
		//{
		//	new SelectElement(element).SelectByText(text);
		//}
	}
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace G3_AutomationFramework.Utils
{
	static class WebElementExtensions
	{
		public static void SetText(this IWebElement element, string text)
		{
			element.SendKeys(text);
		}

		public static void SetDropDownOptionByText(this IWebElement element, string text)
		{
			new SelectElement(element).SelectByText(text);
		}
	}
}

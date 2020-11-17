using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waits
{
	class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = null;
			IWebElement element = null;
			By byElement = null;

			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

			wait.IgnoreExceptionTypes(); // we can transfer an array of exceptions which will be ignored

			wait.PollingInterval = TimeSpan.FromMilliseconds(600);

			wait.Timeout = TimeSpan.FromSeconds(10);
						
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(byElement));

			CustomWaits.WaitForElementIsClickable(driver, element, 3);
		}
	}
}

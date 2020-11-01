using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverG3
{
	static class Helper
	{
		static public void TypeToField(IWebDriver driver, string id, string passText)
		{
			driver.FindElement(By.Id(id)).SendKeys(passText);
		}

		static public void SetImplicitWaitTimeout(IWebDriver driver, int timeout)
		{
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
		}
	}
}

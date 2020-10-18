using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_AutomationFramework.Pages
{
	class BasePage
	{
		public BasePage(IWebDriver driver)
		{
			PageFactory.InitElements(driver, this);
		}
	}
}

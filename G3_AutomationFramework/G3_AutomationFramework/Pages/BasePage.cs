using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace G3_AutomationFramework.Pages
{
	public class BasePage
	{
		public BasePage(IWebDriver driver)
		{			
			PageFactory.InitElements(driver, this);
		}
	}
}

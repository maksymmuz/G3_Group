using G3_AutomationFramework.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace EtsyAutomationTests.Pages
{
	class EtsyMainPage : BasePage
	{
		public EtsyMainPage(IWebDriver driver) : base(driver)
		{
			SearchArea = new SearchArea(driver);
		}

		public SearchArea SearchArea { get; }		
	}
}

using G3_AutomationFramework.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace EtsyAutomationTests.Pages
{
	class EtsyMainPage : BasePage
	{
		public EtsyMainPage(IWebDriver driver) : base(driver)
		{
			searchArea = new SearchArea(driver);
		}

		public SearchArea searchArea;

		// should be moved to separate class
		//[FindsBy(How = How.Id, Using = "global-enhancements-search-query")]
		//public IWebElement searchField;

		//[FindsBy(How = How.CssSelector, Using = "button[value='Search']")]
		//public IWebElement searchButton;
	}
}

using G3_AutomationFramework.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EtsyAutomationTests.Pages
{
	public class EtsySearchPage : BasePage
	{
		public EtsySearchPage(IWebDriver driver) : base(driver)
		{

		}

		[FindsBy(How = How.XPath,
			Using = "//div[@data-search-results]//h3[@class='text-gray text-truncate mb-xs-0 text-body ']")]
		public IList<IWebElement> foundTextItemList;
	}
}

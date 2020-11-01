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
			Using = "//div[@data-search-results]//div[contains(@class,'v2-listing-card__info')]//h3")]
		public IList<IWebElement> foundTextItemList;
	}
}

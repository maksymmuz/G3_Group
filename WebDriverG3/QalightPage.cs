using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects; // *2

// deprecated Support.PageObjects will be remove
//using OpenQA.Selenium.Support.PageObjects; // *1

namespace WebDriverG3
{
	#region *1

	public class QalightPage
	{
		//IWebDriver driver;

		//public QalightPage(IWebDriver driver)
		//{
		//	PageFactory.InitElements(driver, this);
		//}

		//IWebDriver driver;
		//public IWebElement firstNameField;

		//public QalightPage(IWebDriver driver)
		//{
		//	this.driver = driver;
		//firstNameField = driver.FindElement(By.Name("first_name"));
		//lastNameField = driver.FindElement(By.Name("last_name"));
		//}

		//public IWebElement firstNameField = driver.FindElement(By.Name("first_name"));
		//public IWebElement lastNameField = driver.FindElement(By.Name("last_name"));
		#endregion

		#region *2
		public QalightPage(IWebDriver driver)
		{
			PageFactory.InitElements(driver, this);
		}

		[FindsBy(How = How.Name, Using = "first_name")]
		public IWebElement firstNameField;

		[FindsBy(How = How.Name, Using = "last_name")]
		public IWebElement lastNameField;

		[FindsBy(How = How.Name, Using = "telephone")]
		public IWebElement telephoneField;

		[FindsBy(How = How.ClassName, Using = "single-course-form")]
		public IWebElement successRegistrationForm;
	}

	#endregion
}


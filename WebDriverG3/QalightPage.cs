using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
//using SeleniumExtras.PageObjects; // *2

// устаревший подход в Support.PageObjects - должен быть удален
//using OpenQA.Selenium.Support.PageObjects; // *1

namespace WebDriverG3
{
	#region *1

	public class QalightPage
	{
		IWebDriver driver;
		//public IWebElement firstNameField;

		public QalightPage(IWebDriver driver)
		{
			this.driver = driver;
			firstNameField = driver.FindElement(By.Name("first_name"));
			lastNameField = driver.FindElement(By.Name("last_name"));
		}

		public IWebElement firstNameField;
		public IWebElement lastNameField;

		// from first test without PO
		//IWebElement firstNameField = driver.FindElement(By.Name("first_name"));
		//IWebElement lastNameField = driver.FindElement(By.Name("last_name"));
		#endregion

		#region *2
		////right approach
		//public class QalightPage
		//{
		//	IWebDriver driver;

		//	public QalightPage(IWebDriver driver)
		//	{
		//		this.driver = driver;
		//		PageFactory.InitElements(driver, this);
		//	}

		//	//при такой форме звписи инициализаця поля происходит только при обращению к этому полю
		//	[FindsBy(How = How.Name, Using = "first_name")]
		//	public IWebElement firstNameField;

		//	[FindsBy(How = How.Name, Using = "last_name")]
		//	public IWebElement lastNameField;

		//	[FindsBy(How = How.Name, Using = "telephone")]
		//	public IWebElement telephoneField;

		//	[FindsBy (How = How.ClassName, Using = "single-course-form")]
		//	public IWebElement successRegistrationForm;
		//}

		#endregion
	}
}


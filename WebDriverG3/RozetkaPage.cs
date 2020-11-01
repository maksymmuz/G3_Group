using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebDriverG3
{
	public class RozetkaPage
	{
		IWebDriver driver;

		public RozetkaPage(IWebDriver driver)
		{
			this.driver = driver;
			PageFactory.InitElements(driver, this);
		}

		[FindsBy(How = How.ClassName, Using = "header-topline__user-link")]
		public IWebElement signUpButton;

		[FindsBy(How = How.Id, Using = "auth_email")]
		public IWebElement emailField;
		
		[FindsBy(How = How.Id, Using = "auth_pass")]
		public IWebElement passwordField { get; set; }

		public IWebElement PasswordField
		{
			get
			{
				return driver.FindElement(By.Id("auth_pass"));
			}
			set { }
		}

		[FindsBy(How = How.ClassName, Using = "error-message")]
		public IWebElement errorMessage;

		public void TypeEmailToField(string emailText)
		{
			Helper.TypeToField(driver, "auth_email", emailText);
		}

		public void TypePasswordToField(string passText)
		{
			Helper.TypeToField(driver, "auth_pass", passText);
		}

		public void ClickSignUpButton()
		{
			signUpButton.Click();
		}

		public void ClickEmailField()
		{
			emailField.Click();
		}

		public void ClickPasswordField()
		{
			passwordField.Click();
		}
	}
}

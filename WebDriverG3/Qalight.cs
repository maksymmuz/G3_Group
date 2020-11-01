using log4net;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace WebDriverG3
{
	public class Qalight
	{
		IWebDriver driver;
		ILog Log;

		[SetUp]
		public void SetUp()
		{
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			Helper.SetImplicitWaitTimeout(driver, 10);
			//driver.Navigate().GoToUrl("https://qalight.com.ua/kursy/testirovanie/avtomatizatsiya-testirovaniya-selenium/");
			//driver.Navigate().GoToUrl("https://qalight.com.ua/kursy/testirovanie/avtomatizatsiya-testirovaniya-selenium/?ok=ok");
			driver.Navigate().GoToUrl("https://rozetka.com.ua/");
		}

		[TearDown]
		public void TearDown()
		{
			driver.Quit();
		}

		#region Lesson_15
		//[Category("FirstTest")]
		//[Test]
		//public void RegistrationFormTest()
		//{
		//	IWebElement studentNameField = driver.FindElement(By.Name("first_name")); // .SendKeys("StudentName");
		//	studentNameField.SendKeys("firstName");

		//driver.FindElement(By.Name("first_name")).SendKeys("StudentName");

		//IWebElement studentSurNameField = driver.FindElement(By.Name("last_name"));
		//studentSurNameField.SendKeys("lastName");

		//IWebElement phoneField = driver.FindElement(By.XPath("//input[@name='telephone']"));
		//phoneField.SendKeys("0971112233");

		//IWebElement emailField = driver.FindElement(By.CssSelector("[name=email]"));
		//emailField.SendKeys("test@test.co");

		//IWebElement selectWrapper = driver.FindElement(By.CssSelector("div.select:nth-child(1)"));
		//selectWrapper.Click();
		//IWebElement eveningSelectDropDownItem = driver.FindElement(By.CssSelector(".select-options li:nth-child(3)"));
		//eveningSelectDropDownItem.Click();

		//IWebElement submitButton = driver.FindElement(By.CssSelector("[type='submit']"));
		//submitButton.Click();

		//// select drop-down on rozetka
		//IWebElement citySelectOnRozetka = driver.FindElement(By.Name("city-select"));
		//SelectElement citySelectOnRozetkaDropDown = new SelectElement(citySelectOnRozetka);
		//citySelectOnRozetkaDropDown.SelectByIndex(2);
		//citySelectOnRozetkaDropDown.SelectByValue("4: Object"); // Винница
		//var qwe = citySelectOnRozetkaDropDown.Options;


		//string registationFormSelector = ".single-course-form";
		//IWebElement registrationFormSuccess = driver.FindElement(By.CssSelector(registationFormSelector));

		//string registrationFormSuccessText = registrationFormSuccess.Text;
		//string expectedText = "Спасибо за Вашу заявку!";

		//Assert.IsTrue(registrationFormSuccessText.Contains(expectedText), $"Registration form does not contain expected text {expectedText}");

		// another Assert (url check)
		//string currentUrl = driver.Url;
		//string expectedUrl = "https://qalight.com.ua/kursy/testirovanie/avtomatizatsiya-testirovaniya-selenium/?ok=ok";

		//Assert.AreEqual(expectedUrl, currentUrl, $"Current url {currentUrl} isn't equal to expected {expectedUrl}");
		//Assert.IsTrue(expectedUrl == currentUrl, $"Current url {currentUrl} isn't equal to expected {expectedUrl}");

		//Assert.True(IsElementPresent(driver, expectedElementLocator),
		//	$"Element with locator {expectedElementLocator} is not present on the page");

		//Thread.Sleep(2000);
		//var windowHendle = driver.CurrentWindowHandle;
		//}

		//public bool IsElementPresent(IWebDriver driver, string cssLocator)
		//{
		//	var elements = driver.FindElements(By.CssSelector(cssLocator));

		//	if (elements.Count == 1)
		//	{
		//		return true;
		//	}
		//	else if (elements.Count == 0)
		//	{
		//		return false;
		//	}
		//	else
		//	{
		//		throw new Exception("Unexected exception");
		//	}
		//}

		[Test]
		public void RegistrationFormTestWithPageObject()
		{
			QalightPage qalightPage = new QalightPage(driver);
			//qalightPage.firstNameField;
			qalightPage.firstNameField.SendKeys("StudentName");

			qalightPage.lastNameField.SendKeys("StudentSurName");

			//qalightPage.telephoneField.SendKeys("0971112233");

			//Assert.True(IsElementPresent(qalightPage.successRegistrationForm),
			//	$"Element '{nameof(qalightPage.successRegistrationForm)}' is not present on the page");
		}
		#endregion

		#region Lesson_16
		[Test]
		public void RegistrationOnRozetkaPageTest()
		{			
			RozetkaPage rozetkaPage = new RozetkaPage(driver);			
			Console.WriteLine("writeline");
			rozetkaPage.ClickSignUpButton();
			//rozetkaPage.ClickEmailField();
			//rozetkaPage.ClickPasswordField();

			Thread.Sleep(2000);

			IWebElement errorElement = rozetkaPage.errorMessage;

			Assert.IsTrue(IsElementPresent(driver, errorElement),
				$"Element '{nameof(errorElement)}' is not present on the page");
		}

		public bool IsElementPresent(IWebDriver driver, IWebElement webElement)
		{
			//work with implicit wait			
			Helper.SetImplicitWaitTimeout(driver, 1);
			try
			{
				var result = webElement.Displayed;
				Helper.SetImplicitWaitTimeout(driver, 10);
				return true;
			}
			catch (NoSuchElementException)
			{
				Helper.SetImplicitWaitTimeout(driver, 10);
				return false;
			}
			throw new Exception("Unexected exception");
		}

		#endregion
	}
}


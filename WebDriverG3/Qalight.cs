using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace WebDriverG3
{
	public class Qalight
	{
		IWebDriver driver;

		[SetUp]
		public void SetUp()
		{
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
			//SetImplicitWaitTimeout(driver, 10);
			driver.Navigate().GoToUrl("https://qalight.com.ua/kursy/testirovanie/avtomatizatsiya-testirovaniya-selenium/");
			//driver.Navigate().GoToUrl("https://rozetka.com.ua/");

		}

		[TearDown]
		public void TearDown()
		{
			driver.Quit();
		}

		#region Lesson_14
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

		public bool IsElementPresent(IWebElement webElement)
		{
			//try
			//{
			//	var result = webElement.Displayed;
			//	return true;
			//}
			//catch (Exception)
			//{
			//	return false;
			//}

			////right approach
			//try
			//{
			//	var result = webElement.Displayed;
			//	return true;
			//}
			//catch (NoSuchElementException)
			//{
			//	return false;
			//}
			//throw new Exception("Unexected exception");

			//work with implicit wait
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
			//SetImplicitWaitTimeout(driver, 1);
			try
			{
				var result = webElement.Displayed;
				driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
				//SetImplicitWaitTimeout(driver, 10);
				return true;
			}
			catch (NoSuchElementException)
			{
				driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
				//SetImplicitWaitTimeout(driver, 10);
				return false;
			}
			throw new Exception("Unexected exception");
		}

		//public void SetImplicitWaitTimeout(IWebDriver driver, int timeout)
		//{
		//	driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
		//}
		#endregion

		#region Leson13

		[Category("FirstTest")]
		[Test]
		public void RegistrationFormTest()
		{
			IWebElement firstNameField = driver.FindElement(By.Name("first_name")); // .SendKeys("StudentName");
			firstNameField.SendKeys("StudentName");

			IWebElement lastNameField = driver.FindElement(By.Name("last_name"));
			lastNameField.SendKeys("StudentSurName");

			IWebElement telephoneField = driver.FindElement(By.Name("telephone"));
			telephoneField.SendKeys("0971112233");

			IWebElement emailField = driver.FindElement(By.Name("email"));
			emailField.SendKeys("TestEmail@test.com");

			IWebElement selectWrapper = driver.FindElement(By.CssSelector("div.select:nth-child(1)"));
			selectWrapper.Click();
			IWebElement eveningSelectDropDownItem = driver.FindElement(By.CssSelector(".select-options li:nth-child(3)"));
			eveningSelectDropDownItem.Click();


			//// select drop-down on rozetka
			//IWebElement citySelectOnRozetka = driver.FindElement(By.Name("city-select"));
			//SelectElement citySelectOnRozetkaDropDown = new SelectElement(citySelectOnRozetka);
			//citySelectOnRozetkaDropDown.SelectByIndex(2);
			//citySelectOnRozetkaDropDown.SelectByValue("4: Object"); // Винница
			//var qwe = citySelectOnRozetkaDropDown.Options;

			string expectedElementLocator = ".single-course-form"; // should be moved to arrange section

			Assert.True(IsElementPresent(driver, expectedElementLocator),
				$"Element with locator {expectedElementLocator} is not present on the page");

			Thread.Sleep(2000);
			Console.WriteLine("All Ok");
			var windowHendle = driver.CurrentWindowHandle;
		}

		public bool IsElementPresent(IWebDriver driver, string cssLocator)
		{
			// wrong approach
			//try
			//{
			//	var element = driver.FindElement(By.CssSelector(cssLocator));
			//}
			//catch (Exception)
			//{
			//	throw;
			//}

			var elements = driver.FindElements(By.CssSelector(cssLocator));
			if (elements.Count == 1)
			{
				return true;
			}
			else if (elements.Count == 0)
			{
				return false;
			}
			else
			{
				throw new Exception("Unexected exception");
			}
		}

		#endregion
	}
}

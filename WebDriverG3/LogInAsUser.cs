using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebDriverG3
{
	class LogInAsUser
	{
		IWebDriver driver;

		public LogInAsUser(IWebDriver driver)  //создаем класс драйвера
		{
			this.driver = driver;
		}

		// [TestMethod]
		public void SetName(string userLogin)  //метод записи логина
		{
			IWebElement setEmail = driver.FindElement(By.Id("email"));  //находим поле ввода и вписываем логин
			setEmail.SendKeys(userLogin);
		}

		public void SetPass(string userPass)  //метод записи пароля
		{
			IWebElement setPass = driver.FindElement(By.Id("pass"));  //находим поле ввода и вписываем пароль
			setPass.SendKeys(userPass);
		}

		public void ClickButton()
		{
			IWebElement button = driver.FindElement(By.CssSelector("button#u_0_f"));

			button.Click();  //находим кнопку входа и нажимаем
		}

		public void LogInActions(string userLogin, string userPass)
		{
			SetName(userLogin);
			SetPass(userPass);
			Thread.Sleep(2000);
			ClickButton();
		}
	}
}

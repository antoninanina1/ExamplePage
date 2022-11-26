using OpenQA.Selenium;
using WebDriver = ExamplePage.Driver.WebDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePage.Page
{
    public class LoginPage
    {
        private IWebDriver driver = WebDriver.Instance;

        public IWebElement FullName => driver.FindElement(By.Id("name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("login"));
       

        public void LoginUser(string name, string pass)
        {
            FullName.SendKeys(name);
            Password.SendKeys(pass);
            LoginButton.Click();
        }
    }
}

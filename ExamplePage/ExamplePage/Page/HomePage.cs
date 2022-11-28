using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriver = ExamplePage.Driver.WebDriver;

namespace ExamplePage.Page
{
    public class HomePage
    {
        private IWebDriver driver => WebDriver.Instance;  

        public IWebElement FullName => driver.FindElement(By.Id("name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("login"));
        public IWebElement Country => driver.FindElement(By.Id("country"));
        public IWebElement Address => driver.FindElement(By.Id("address"));
        public IWebElement Email => driver.FindElement(By.Id("email"));
        public IWebElement Phone => driver.FindElement(By.Id("phone"));
        public IWebElement SaveButton => driver.FindElement(By.Id("save"));
        public IWebElement LogoutButton  => driver.FindElement(By.Id("logout"));
        public IWebElement SaveText => driver.FindElement(By.ClassName("tp-saved"));
      

        public void SelectOption(string option)
        {
            SelectElement drop = new SelectElement(driver.FindElement(By.Id("country")));
            drop.SelectByText(option);
        }

        
       
    }
}

using ExamplePage.Driver;
using ExamplePage.Page;
using NUnit.Framework;

namespace ExamplePage
{
    public class Tests
    {
        private LoginPage loginPage;
        private HomePage homePage;

        [SetUp]
        public void BeforeScenario()
        {
            WebDriver.Initialize();
            loginPage = new LoginPage();
            homePage = new HomePage();

        }
        [TearDown]
        public void AfterScenario()
        {
            WebDriver.CleanUp();

        }
        [Test]
        public void TC01_FillInputWithValidData_ShouldAllDataDisplayedInInput()
        {
            loginPage.FullName.SendKeys("Antonina");
            loginPage.Password.SendKeys("12345");
            loginPage.LoginButton.Click();
        }
        [Test]
        public void TC02_FillIputWithValidData_CompleteTheTestForm()
        {
            loginPage.FullName.SendKeys("Antonina");
            loginPage.Password.SendKeys("12345");
            loginPage.LoginButton.Click();     

            homePage.SelectOption("Serbia");
            homePage.Address.SendKeys("Beograd");
            homePage.Email.SendKeys("mail@mail.com");
            homePage.Phone.SendKeys("0549237651");
            homePage.SaveButton.Click();
            

            Assert.That("Saved", Is.EqualTo(homePage.SaveText.Text));
        }
        public void Login(string name, string pass)
        {
            loginPage.LoginUser(name, pass);
        }


    }
}
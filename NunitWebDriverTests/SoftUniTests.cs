using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NunitWebDriverTests
{
    public class SoftUniTests
    {
        private WebDriver driver;

        [OneTimeSetUp]
        public void Setup_OpenBrowserAndNavigate()
        {
            this.driver = new ChromeDriver();
            driver.Url = "https://softuni.bg";
            driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void ShutDown() 
        {
            driver.Quit();
        }

        [Test]
        public void Test_AssertMainPageTitle()
        {
            driver.Url = "https://softuni.bg"; // navigate to the main Page
            string expectedTitle = "Обучение по програмиране - Софтуерен университет";

            //Assert Phase  of Tripple AAA Pattern
            //Assert.Pass(expectedTitle, driver.Title);
            Assert.That(driver.Title, Is.EqualTo(expectedTitle));           
        }

        [Test]
        public void Test_AssertAboutUsTitle()
        {
            string expectedTitle = "За нас - Софтуерен университет";

            var zaNasElement = driver.FindElement(By.CssSelector("#header-nav > div.toggle-nav.toggle-holder > ul > li:nth-child(1) > a > span"));
            zaNasElement.Click();

            Assert.That(driver.Title, Is.EqualTo(expectedTitle));           
        }
    }
}
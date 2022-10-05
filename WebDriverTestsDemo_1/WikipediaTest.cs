using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WebDriverTestsDemo_1
{
    internal class WikipediaTest
    {
        static void Main(string[] args)
        {
            //create new Chrome browser instance
            var driver = new ChromeDriver();

            //Navigate to Wikipedia
            driver.Url = "https://wikipedia.org";
            Console.WriteLine("CURRENT TITLE : " + driver.Title);

            //Locate searchFiled by ID
            var searchField = driver.FindElement(By.Id("searchInput"));

            //click on element
            searchField.Click();

            //// fill message QA and press Enter keyboard button
            searchField.SendKeys("QA" + Keys.Enter); 

            Console.WriteLine("TITLE AFTER SEARCH: " + driver.Title);

            //Close Browser and conection
            //driver.Quit();

        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWorkflowQuestion2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl("https://www.weightwatchers.com/us/");
            Assert.AreEqual(driver.Title,"Weight Loss Program, Recipes & Help | Weight Watchers");
            driver.FindElement(By.Id("ela-menu-visitor-desktop-supplementa_find-a-meeting")).Click();
             Assert.AreEqual(driver.Title, "Get Schedules & Times Near You");
            driver.FindElement(By.Id("meetingSearch")).SendKeys("10011");
            driver.FindElement(By.XPath("//button[@class='btn btn-default form-blue-pill__btn']")).Click();
            string firstResult = driver.FindElement(By.XPath(".//div[@class='meeting-locations-list__item'][1]//span")).Text;
            Console.WriteLine(firstResult);
            Console.WriteLine(driver.FindElement(By.XPath(".//div[@class='meeting-locations-list__item'][1]//div[@class='location__distance']")).Text);
            driver.FindElement(By.XPath(".//div[@class='meeting-locations-list__item'][1]//span")).Click();
            Assert.AreEqual(firstResult, driver.FindElement(By.XPath(".//div[@class='location__name']//span")).Text);
            
            Console.WriteLine(driver.FindElement(By.XPath(".//div[@class='hours-list-item-wrapper hours-list--currentday']/div")).Text);
            IList<IWebElement> element = driver.FindElements(By.XPath(".//div[@class='hours-list-item-wrapper hours-list--currentday']/div[2]/div"));
            foreach(IWebElement e in element)
            {
                Console.WriteLine(e.Text);
            }
            driver.Close();
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Learning2018
{
    [TestClass]
    public class Waiting
    {
        IWebDriver driver;
        [TestMethod]
        public void TestMethodforImplicitWait()
        {
            
            try
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.google.co.in/");
                driver.Manage().Window.Maximize();
                //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5); 
                string HomeText = driver.FindElement(By.Id("menu-item-1635980")).Text;
                

            }
            catch (Exception e)
            {
                Assert.Fail("Test Case failed, Could not find Home Button. ::: "+e.Message);
                

            }
            finally
            {
                driver.Quit();
            }

        }
    }
}

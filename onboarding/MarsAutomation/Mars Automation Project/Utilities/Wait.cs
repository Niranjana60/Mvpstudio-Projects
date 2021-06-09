using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Automation_Project.Utilities
{
    class Wait
    {

        //generic function to wait-element exists
        public static void ElementExists(IWebDriver driver, String locator, string locatorvalue, int seconds)
        {
            try
            {
                if (locator == "Id")
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorvalue)));
                }

                if (locator == "XPath")
                {
                    Console.WriteLine(">>>>>>>>>> Adding Wait");
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorvalue)));
                }


            }

            catch (Exception ex)
            {
                Assert.Fail("Test Failed waiting for element to exists", ex.Message);
            }
        }




        public static void ElementToBeClicked(IWebDriver driver, String locator, string locatorvalue, int seconds)
        {
            try
            {
                if (locator == "Id")
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorvalue)));
                }

                if (locator == "XPath")
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorvalue)));
                }


            }

            catch (Exception ex)
            {
                Assert.Fail("Test Failed waiting for element to click", ex.Message);
            }
        }
    }
}



      
        









































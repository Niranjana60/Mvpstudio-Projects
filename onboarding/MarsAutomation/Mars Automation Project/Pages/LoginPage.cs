using Mars_Automation_Project.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Mars_Automation_Project.Pages
{
    class LoginPage
    {
        private readonly IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Navigate to url
        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        //click on SignIn Button
        public void ClickSignInButton()
        {
            IWebElement signInButton = driver.FindElement(By.XPath("//a[@class='item'][text()='Sign In']"));
            signInButton.Click();
        }

        // Add credentials email and password
        public void AddCredentials(string email, string password)
        {
            Wait.ElementExists(driver, "X Path", "//INPUT[@type='text'])[2]", 2);

            //Enter email
            IWebElement emailElement = driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
            emailElement.SendKeys(email);
            //Enter Password
            IWebElement passwordElement = driver.FindElement(By.XPath("//INPUT[@type='password']"));
            passwordElement.SendKeys(password);
        }

        //Click on Login
        public void ClickLoginButton()
        {

            Wait.ElementExists(driver, "X Path", "//BUTTON[@class='fluid ui teal button'][text()='Login']", 2);
            IWebElement loginButton = driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));
            loginButton.Click();
        }

        //Validating if logged in successfully
        public bool ValidateLogin()
        {
            Wait.ElementExists(driver, "XPath", "//body[1]/div[1]/div[1]/section[1]/div[1]/a[2]", 5);
            IWebElement profile = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[1]/div[1]/a[2]"));
            String expectedtitle = "Profile";
            String actualtitle = profile.Text;
            if (actualtitle == expectedtitle)
            {
                Console.WriteLine("test passed");
                return true;
            }
            else
            {
                Console.WriteLine("test failed");
                return false;
            }

        }

        public void QuickLogin(String url, String email, String password)
        {
            Navigate(url);
            ClickSignInButton();
            AddCredentials(email, password);
            ClickLoginButton();
        }
    }
}

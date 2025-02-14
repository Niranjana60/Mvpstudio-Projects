﻿using MarsFramework.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace Mars_Competition_Task.Pages
{
    class SignIn


    {
        public SignIn()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }


        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }



        #endregion

        public void LoginSteps()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");
            string url = GlobalDefinitions.ExcelLib.ReadData(1, "url");
            string email = GlobalDefinitions.ExcelLib.ReadData(1, "email");
            string password = GlobalDefinitions.ExcelLib.ReadData(1, "password");

            MarsFramework.Global.GlobalDefinitions.driver.Navigate().GoToUrl(url);

            SignIntab.Click();
            Email.SendKeys(email);
            Password.SendKeys(password);
            LoginBtn.Click();
            Thread.Sleep(4000);
           

        }
       
       

        }

    }
    


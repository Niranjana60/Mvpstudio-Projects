﻿using Mars_Automation_Pro.Pages;
using Mars_Automation_Project.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Mars_Automation_Project.Steps
{
    [Binding]
    public class ProfilePageSteps: IDisposable
    { 
        private readonly ProfilePage profilePage;
        private readonly LoginPage loginPage;

        private readonly IWebDriver driver;

        public ProfilePageSteps()
        {
            driver = new ChromeDriver();
            profilePage = new ProfilePage(driver);
            loginPage = new LoginPage(driver);
        }
    
    
        [Given(@"I am logged in at ""(.*)"" as user ""(.*)"" with password ""(.*)""")]
        public void GivenIAmLoggedInAtAsUserWithPassword(string url, string email, string password)
        {
            loginPage.QuickLogin(url, email, password);
            Console.WriteLine("I am in the login page at " + url);
        }

        [Given(@"I am at the Profile page")]
        public void GivenIAmAtTheProfilePage()
        {
            Assert.IsTrue(profilePage.IsValidProfilePage());
            Console.WriteLine("I am at the Profilepage");
        }

        [When(@"I click on Add New button")]
        public void WhenIClickOnAddNewButton()
        {
            profilePage.ClickOnAddNewButtonBelowLanguageTab();
            Console.WriteLine("I click on Add New button");
        }

        [When(@"I click on Add New button below Skills tab")]
        public void WhenIClickOnAddNewButtonBelowSkillsTab()
        {
            profilePage.ClickOnAddNewButtonBelowSkillsTab();
            Console.WriteLine("I click on Add New button below skills tab");
        }

        [When(@"I Add (.*) and (.*) on Languages tab")]
        public void WhenIAddLanguage(string language, string languageLevel)
        {
            profilePage.AddLanguage(language, languageLevel);

            Console.WriteLine("I Add Language");
        }

        [When(@"I Add (.*) and (.*) on Skills tab")]
        public void WhenIAddAndOnSkillsTab(string skill, string skillLevel)
        {
            profilePage.AddSkill(skill, skillLevel);

            Console.WriteLine("I Add Skill");
        }


        [When(@"I click on Add button")]
        public void WhenIClickOnAddButton()
        {

            profilePage.ClickOnAddButton();
            Console.WriteLine("I click on Add button");
        }



  

        [Then(@"Validate that (.*) and (.*) are added")]
        public void ThenValidateThatLanguageAndLevelAreAdded(string language, string level)
        {
            bool isLanguageAdded = profilePage.ValidateLanguageIsAdded(language);
            Assert.IsTrue(isLanguageAdded);
            bool isLanguageLevelAdded = profilePage.ValidateLanguageLevelIsAdded(level);
            Assert.IsTrue(isLanguageLevelAdded);
        }

        [Then(@"Validate that (.*) and (.*) are added\.")]
        public void ThenValidateThatSkillAndSkillLevelAreAdded_(string skill, string level)
        {
           bool isSkillAdded = profilePage.ValidateSkillIsAdded(skill);
            Assert.IsTrue(isSkillAdded);
            bool isSkillLevelAdded = profilePage.ValidateSkillLevelIsAdded(level);
            Assert.IsTrue(isSkillLevelAdded);
        }


        

        [Given(@"I click on Skills tab")]
        public void GivenIClickOnSkillsTab()
        {
            profilePage.ClickOnSkillTab();
            Console.WriteLine("I click on Skills tab");
        }


        public void Dispose()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}

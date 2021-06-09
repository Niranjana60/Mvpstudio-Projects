using Mars_Automation_Project.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Mars_Automation_Pro.Pages
{
    class ProfilePage
    {

        private readonly IWebDriver driver;
        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //click on AddNew Button below Language Tab
        public void ClickOnAddNewButtonBelowLanguageTab()
        {
            
            
            IWebElement addNewButtonOfLanguageTab = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            Wait.ElementToBeClicked(driver, "XPath", "//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]", 8);
            addNewButtonOfLanguageTab.Click();
        }


        //click on AddNew Button below skills Tab
        public void ClickOnAddNewButtonBelowSkillsTab()
        {
            Wait.ElementExists(driver, "XPath", "//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]", 5);
        
            IWebElement addNewButtonOfSkillTab = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            addNewButtonOfSkillTab.Click();
        }

        //Adding Languages from below language tab
        public void AddLanguage(String language, String level)
        {

            Wait.ElementExists(driver, "XPath", "//input[@placeholder='Add Language']", 5);
          
            IWebElement addLanguage = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            addLanguage.SendKeys(language);

            var languageLevelDropdown = driver.FindElement(By.XPath("//select[@name='level']"));
            //create selectelement object
            var selectElement = new SelectElement(languageLevelDropdown);

            selectElement.SelectByValue(level);
        }

        //Adding skills from below skill tab
        public void AddSkill(String Skill, String level)
        {
          
            Wait.ElementExists(driver, "XPath", "//input[@placeholder='Add Skill']", 5);
            IWebElement addskill = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            addskill.SendKeys(Skill);
            
            var skillLevelDropDown = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]"));
            //create selectelement object
            var selectElement = new SelectElement(skillLevelDropDown);

            selectElement.SelectByValue(level);

        }

        //Click on skill tab
        public void ClickOnSkillTab()
        {
            
            Wait.ElementToBeClicked(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 3);
            IWebElement skillstab = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillstab.Click();
        }

        //Click on AddButton
        public void ClickOnAddButton()
        {

           Wait.ElementToBeClicked(driver, "XPath", "//input[@value='Add']", 3);
          
            IWebElement add = driver.FindElement(By.XPath("//input[@value='Add']"));
            add.Click();
        }

        //validate ProfilePage is added
        public bool IsValidProfilePage()
        {
            
            Wait.ElementExists(driver, "XPath", "//a[contains(text(),'Share Skill')]", 5);
            IWebElement shareskill = driver.FindElement(By.XPath("//a[contains(text(),'Share Skill')]"));
            Console.WriteLine("*******" + shareskill.Text);
            return shareskill.Text == "Share Skill";
           
        }


        //validate Language is added
        public bool ValidateLanguageIsAdded(string language)
        {
           
            Wait.ElementExists(driver, "XPath", "//td[normalize-space()='" + language + "']", 5);
            IWebElement languageLabel = driver.FindElement(By.XPath("//td[normalize-space()='" + language + "']"));
            Console.WriteLine("<<<<<<<< SELECTOR HUB >>>>>:" + languageLabel.Text);
            bool isLanguagePresent = languageLabel.Text.Equals(language);
            return isLanguagePresent;
        }

        //validate LanguageLevel is added
        public bool ValidateLanguageLevelIsAdded(string languagelevel)
        {
           
            Wait.ElementExists(driver, "XPath", "//td[normalize-space()='" + languagelevel + "']", 5);
            IWebElement languageLevelLabel = driver.FindElement(By.XPath("//td[normalize-space()='" + languagelevel + "']"));
            Console.WriteLine("<<<<<<<< SELECTOR HUB >>>>>:" + languageLevelLabel.Text);
            bool isLevelPresent = languageLevelLabel.Text.Equals(languagelevel);
            return isLevelPresent;
        }

        //validate skill is added
        public bool ValidateSkillIsAdded(string skill)
        {
            
            Wait.ElementExists(driver, "XPath", "//td[normalize-space()='" + skill + "']", 4);
            IWebElement skillLabel = driver.FindElement(By.XPath("//td[normalize-space()='" + skill + "']"));
            Console.WriteLine("<<<<<<<< SELECTOR HUB >>>>>:" + skillLabel.Text);
            bool isSkillPresent = skillLabel.Text.Equals(skill);
            return isSkillPresent;

          }

        //validate skill Level is added
        public bool ValidateSkillLevelIsAdded(string skillLevel)
        {
            
            Wait.ElementExists(driver, "XPath", "//td[normalize-space()='" + skillLevel + "']", 4);
            IWebElement skillLevelLabel = driver.FindElement(By.XPath("//td[normalize-space()='" + skillLevel + "']"));
            Console.WriteLine("<<<<<<<< SELECTOR HUB >>>>>:" + skillLevelLabel.Text);
            bool isSkillLevelPresent = skillLevelLabel.Text.Equals(skillLevel);
            return isSkillLevelPresent;
        }

    }
}

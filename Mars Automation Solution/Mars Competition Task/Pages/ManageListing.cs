using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mars_Competition_Task.Pages
{
    class ManageListing
    {

        public ManageListing()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }


        //Click on Manage Listings Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Manage Listings')]")]
        private IWebElement ManageListingsLink { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[1]/i")]
        private IWebElement viewicon { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[2]")]
        private IWebElement deleteelement { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement Edit { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }

        //Click on Yes 
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]
        private IWebElement YesButton { get; set; }
        //Click on Yes 
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]/i")]
        private IWebElement Deleteicon { get; set; }
        //Click on Category value
        [FindsBy(How = How.XPath, Using = "//*[@id='listing - management - section']/div[2]/div[1]/div[1]/table/tbody/tr/td[2]")]
        private IWebElement Category { get; set; }

        //Click on Category 
        [FindsBy(How = How.XPath, Using = "//*[@id='listing - management - section']/div[2]/div[1]/div[1]/table/thead/tr/th[2]")]
        private IWebElement CategoryValue { get; set; }




        public void ClickOnEditLinkIcon()
        {

             //MarsFramework.Global.GlobalDefinitions.ElementExists("XPath","//i[@class='outline write icon'])[1]", 6);
            Thread.Sleep(6000);
            Edit.Click();
        }


        public void ClickOnManageListings()
        {
           // GlobalDefinitions.ElementExists("LinkText", "Manage Listings", 5);
            Thread.Sleep(5000);
            ManageListingsLink.Click();

        }
        public void ValidateView()
        {
            ManageListingsLink.Click();
            viewicon.Click();
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListing");
            string url = GlobalDefinitions.ExcelLib.ReadData(1, "url");
            MarsFramework.Global.GlobalDefinitions.driver.Navigate().GoToUrl(url);


        }

    

        public void DeleteSkill()
        {
            Thread.Sleep(3000);
            Deleteicon.Click();
            //deleteelement.Click();
           //Thread.Sleep(2000);
          
            YesButton.Click();
            

        }

        public String DeleteSkillValidation()
        {

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");


            string description = GlobalDefinitions.ExcelLib.ReadData(1, "Description");
            String categorytext = Category.Text;
            return categorytext;
            String categoryValue = CategoryValue.Text;
            return categoryValue;
        }

        public void Clickoneyeicon()
        {

            //GlobalDefinitions.ElementExists("XPath", "//*[@id='listing - management - section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[1]/i", 2);
            Thread.Sleep(5000);
            viewicon.Click();
            //Thread.Sleep(2000);
        }


        public void Navigate(string url)
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ServiceDetail");
            string urlname = GlobalDefinitions.ExcelLib.ReadData(1, "url");
            MarsFramework.Global.GlobalDefinitions.driver.Navigate().GoToUrl(url);
        }


       
    }
}

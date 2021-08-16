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
    class ManageListingPage
    {

        public ManageListingPage()
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

        //Click on Yes 
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]
        private IWebElement YesButton { get; set; }
        //Click on No
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[1]")]
        private IWebElement NoButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[8]/div[1]/button[3]/i[1]")]
        private IWebElement Deleteicon { get; set; }
        //Click on Category value
        [FindsBy(How = How.XPath, Using = "//*[@id='listing - management - section']/div[2]/div[1]/div[1]/table/tbody/tr/td[2]")]
        private IWebElement Category { get; set; }

        //Click on Category 
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]")]
        private IWebElement CategoryValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]")]
        private IWebElement TitleValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]")]
        private IWebElement DescriptionValue { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[5]")]
        private IWebElement ServiceTypeValue { get; set; }
        // Description
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]")]
        private IWebElement Description { get; set; }
        [FindsBy(How = How.XPath, Using = "//tbody/tr[2]/td[6]/i[1]")]
        private IWebElement SkillTradeEnabledIcon { get; set; }
        [FindsBy(How = How.XPath, Using = "//tbody/tr[2]/td[7]/div[1]/input[1]")]
        private IWebElement ActiveRadioButton { get; set; }

        //Delete success message
        [FindsBy(How = How.XPath, Using = "//div[@class='ns-box-inner']")]
        private IWebElement Deletemessage { get; set; }

     

        public void ClickOnEditLinkIcon()
        {

            //MarsFramework.Global.GlobalDefinitions.ElementExists("XPath","//i[@class='outline write icon'])[1]", 6);
            Thread.Sleep(5000);
            Edit.Click(); 
        }


        public void ClickOnManageListingsLink()
        {
            GlobalDefinitions.ElementExists("LinkText", "Manage Listings", 5);
            
            ManageListingsLink.Click();

        }
        public void ClickManageListingEyeIcon()
        {
            //ManageListingsLink.Click();
            GlobalDefinitions.ElementExists("XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[1]/i", 5);
            viewicon.Click();
        }
            

        public String ValidateUserIsAtManageListingPage()
        {
            String manageListLinkText = ManageListingsLink.Text;
            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + manageListLinkText);
            return manageListLinkText;
        }

        public String ValidateDescriptionIsEditted()
           
        {
            GlobalDefinitions.ElementExists("XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]", 3);
            String description = Description.Text;
            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + description);
            return description;

        }

        public String ValidateCategory()
        {
            GlobalDefinitions.ElementExists("XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]", 5);
            String categoryvalue = CategoryValue.Text;
            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + categoryvalue);
            return categoryvalue;
        }

        public String ValidateTitle()
        {
            GlobalDefinitions.ElementExists("XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]", 5);
            String titlevalue = TitleValue.Text;
            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + titlevalue);
            return titlevalue;

        }

        public String ValidateDescriptionValue()
        {
             GlobalDefinitions.ElementExists("XPath", "//td[normalize-space()='Description editted']", 5);
            //Thread.Sleep(9000);
            String descriptionvalue = DescriptionValue.Text;
            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + descriptionvalue);
            return descriptionvalue;

        }


        public String ValidateServiceTypeValue()
        {
            GlobalDefinitions.ElementExists("XPath", "//td[normalize-space()='One-off']", 5);
            String serviceTypeValue = ServiceTypeValue.Text;
            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + serviceTypeValue);
            return serviceTypeValue;

        }


        public bool ValidateSkillTrade()
        {
            GlobalDefinitions.ElementExists("XPath","//tbody/tr[2]/td[6]/i[1]",5);
            return SkillTradeEnabledIcon.Enabled;
        }

        public bool ValidateActive()
        {
            GlobalDefinitions.ElementExists("XPath", "//input[@name='isActive']", 5);
            return ActiveRadioButton.Enabled;
        }



        public void DeleteSkill()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListing");
           
            GlobalDefinitions.ElementExists("XPath","//tbody/tr[1]/td[8]/div[1]/button[3]/i[1]",5);
            Deleteicon.Click();
            string yesButton = GlobalDefinitions.ExcelLib.ReadData(1, "Deleteaction");
            
            if(yesButton == "Yes")
            {
                
                YesButton.Click();
                Thread.Sleep(5000);
               //GlobalDefinitions.ElementExists("XPath", "/html/body/div[2]/div/div[3]/button[2]", 5);
                
            }
            else
            {
                NoButton.Click();
            }
            

        }

        public string ValidateDeleteSkill()
        {
            
            String deleteMessageTest = Deletemessage.Text;
            Thread.Sleep(5000);
            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + deleteMessageTest);
            return deleteMessageTest;
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

            GlobalDefinitions.ElementExists("XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[1]/i",5);
            
            viewicon.Click();
            
        }


        public void Navigate(string url)
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ServiceDetail");
            string urlname = GlobalDefinitions.ExcelLib.ReadData(1, "url");
            MarsFramework.Global.GlobalDefinitions.driver.Navigate().GoToUrl(url);
        }


       
    }
}

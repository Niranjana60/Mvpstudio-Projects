using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using AutoItX3Lib;
namespace Mars_Competition_Task.Pages
{
    class ShareSkillPage
    {

        public ShareSkillPage()
        {
            PageFactory.InitElements(MarsFramework.Global.GlobalDefinitions.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        ////Enter the Title in textbox
        //[FindsBy(How = How.Name, Using = "title")]
        //private IWebElement Title { get; set; }
        //div[text()
        //Enter the Title in textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")]
        private IWebElement Title { get; set; }

        ////After Entering the TitleValue in textbox
        //[FindsBy(How = How.XPath, Using = "//div[Contains(text()='Title is Entered']")]
        //private IWebElement TitleValue { get; set; }
        //After Entering the TitleValue in textbox
        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder='Write a title to describe the service you provide']")]
        private IWebElement TitleValue { get; set; }


        //Enter the Description in textbox
        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on Category Dropdownvalue
       // [FindsBy(How = How.XPath, Using = "//select/option[@value='Digital Marketing']")]
       // private IWebElement CategoryDropDownValue { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        private IWebElement ServiceTypeOptions { get; set; }
        //Select the onoffserviceradiobutton
        [FindsBy(How = How.XPath, Using = "//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]")]
        private IWebElement OneOffServiceRadioButton { get; set; }
        //Select the onoffserviceradiobutton
        [FindsBy(How = How.XPath, Using = "//div[5]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement HourlyServiceRadioButton { get; set; }

        //[FindsBy(How = How.Name, Using = "locationType")]
        [FindsBy(How = How.CssSelector, Using = "input[value='1'][name='locationType']")]
        private IWebElement OnlineRadioButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[value='0'][name='locationType']")]
        private IWebElement OnsiteRadioButton { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Click on Skill Trade-SkillExchangeRadiobutton option
        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[2]/div[1]/div[1]/div[1]/input[1]")]
        private IWebElement SkillExchangeRadiobutton { get; set; }
        //Click on Skill Trade-Credit radiobutton option
        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[2]/div[1]/div[2]/div[1]/input[1]")]
        private IWebElement CreditRadioButton { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }
        //Click on ActiveRadioButton option
        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[10]/div[2]/div[1]/div[1]/div[1]/input[1]]")]
        private IWebElement ActiveRadioButton { get; set; }
        //Click on HiddenRadioButton option
        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[10]/div[2]/div[1]/div[2]/div[1]/input[1]")]
        private IWebElement HiddenRadioButton { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        //Click on Marketing tag
        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[4]/div[2]/div[1]/div[1]/div[1]/span[1]")]
        private IWebElement MarketingTag { get; set; }

        //Click on Skill exchange Performance testing tag
        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[4]/div[1]/div[1]/div[1]/div[1]/span[1]")]
        private IWebElement PerformancetestingTag { get; set; }


        //Click on upload button
        [FindsBy(How = How.Id, Using = "selectFile")]
        private IWebElement WorksampleIcon { get; set; }


        public void clickShareskillbutton()
        {
            MarsFramework.Global.GlobalDefinitions.wait(5);
            ShareSkillButton.Click();

        }

        public void EnterTitle()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            string title = GlobalDefinitions.ExcelLib.ReadData(1, "Title");
            Thread.Sleep(5000);
            ShareSkillButton.Click();
            //MarsFramework.Global.GlobalDefinitions.wait(3);
            Thread.Sleep(5000);
            Title.SendKeys(title);
            ////////Thread.Sleep(5000);
            

        }

        public String TitleValidation()
        {
            Thread.Sleep(5000);
            String titletext = Title.Text;
            Thread.Sleep(5000);

            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + titletext);
            return titletext;



        }


        public String ValidateAtShareSkillPage()
        {
            MarsFramework.Global.GlobalDefinitions.ElementExists("LinkText", "Share Skill", 5);
            String ShareSkillButtontext = ShareSkillButton.Text;


            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + ShareSkillButtontext);
            return ShareSkillButtontext;

        }
        public void EnterDescription()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");


            string description = GlobalDefinitions.ExcelLib.ReadData(1, "Description");
            Thread.Sleep(5000);
            ShareSkillButton.Click();
            Thread.Sleep(3000);
            Description.SendKeys(description);
            // MarsFramework.Global.GlobalDefinitions.wait(3);


        }
        public String ValidateDescription()
        {
            String text = Description.Text;
            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + text);
            return text;
        }
        public void ClickOnCategory()
        {
            Thread.Sleep(4000);
            ShareSkillButton.Click();
            Thread.Sleep(5000);
            CategoryDropDown.Click();
            Thread.Sleep(3000);
        }

        public void ClickOnSubCategory()
        {
            //Thread.Sleep(4000);
            //ShareSkillButton.Click();
            Thread.Sleep(5000);
            SubCategoryDropDown.Click();
            Thread.Sleep(5000);
        }
        public void SelectCategory()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            String categoryDropDownValue = GlobalDefinitions.ExcelLib.ReadData(1, "Category");
           
            var selectElement = new SelectElement(CategoryDropDown);

            Thread.Sleep(5000);

            selectElement.SelectByText(categoryDropDownValue);

            Thread.Sleep(5000);
        }

        public void SelectSubCategory()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            String subCategoryDropDownValue = GlobalDefinitions.ExcelLib.ReadData(1, "Subcategory");
            var selectElement = new SelectElement(SubCategoryDropDown);
            Thread.Sleep(5000);

            selectElement.SelectByText(subCategoryDropDownValue);
            Thread.Sleep(5000);

        }

        public void SaveSkills()
        {
            Thread.Sleep(3000);
            ShareSkillButton.Click();
            Thread.Sleep(5000);
            Save.Click();
            Thread.Sleep(8000);
        }

        public bool ValidateSkillTradeSkillExchangeRadioButton()
        {
            return SkillExchangeRadiobutton.Selected;
        }

        

        public String ValidateSkillTrade()
        {
            //skill exchange is selected
            String text = Description.Text;
            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + text);
            return text;
        }
        public String ValidateDescriptionEditting()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            Thread.Sleep(4000);
            ShareSkillButton.Click();



            string description = GlobalDefinitions.ExcelLib.ReadData(2, "Description");
            Thread.Sleep(4000);
            Description.SendKeys(description);

            String text = Description.Text;
            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + text);
            return text;



        }


        public void EditSkill()

        {
            //Description is editted in skill
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            Thread.Sleep(5000);
            Description.Clear();
            string description = GlobalDefinitions.ExcelLib.ReadData(2, "Description");
            MarsFramework.Global.GlobalDefinitions.wait(4);
            Description.SendKeys(description);
            // Thread.Sleep(1000);
            // Save.Click();

        }

        public string DescriptionEdittedText()
        {
            String DescriptionEdittedText = Description.Text;
            return DescriptionEdittedText;
        }


        public void FileUpload()
        {
            AutoItX3 autoIt = new AutoItX3();
            WorksampleIcon.Click();
            autoIt.WinActivate("Open");
            autoIt.Send(@"C:\Users\nirur\Desktop\san\bugfile.png");
            Thread.Sleep(1000);
            autoIt.Send("{Enter}");




        }


        public void SelectLocationType()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            Thread.Sleep(6000);
            ShareSkillButton.Click();
            //Global.GlobalDefinitions.wait(15);

            string locationTypeOption = GlobalDefinitions.ExcelLib.ReadData(1, "LocationType");

            if (locationTypeOption == "On-site")
            {
                Thread.Sleep(3000);

                OnsiteRadioButton.Click();
                //Thread.Sleep(8000);
            }

            else
            {
                Thread.Sleep(3000);
                OnlineRadioButton.Click();

            }

        }
        public bool validateOnsiteRadiobuttonSelected()
        {
            return OnsiteRadioButton.Selected;
            //Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + OnsiteRadioButton);

        }

    

        public void SelectServiceType()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            Thread.Sleep(6000);
            ShareSkillButton.Click();
            //Global.GlobalDefinitions.wait(15);

            string ServiceTypeOption = GlobalDefinitions.ExcelLib.ReadData(1, "ServiceType");
            if (ServiceTypeOption == "One-off service")
            {
                OneOffServiceRadioButton.Click();
                Thread.Sleep(3000);
            }

            else
            {
                Thread.Sleep(3000);
                HourlyServiceRadioButton.Click();

            }
        }

        public bool ValidateServiceType()
        {   //oneoffserviceradiobuttonisselected
            return OneOffServiceRadioButton.Selected;
        }
        


        public void EnterTags()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            String tag = GlobalDefinitions.ExcelLib.ReadData(1, "Tag");
            Thread.Sleep(5000);
            ShareSkillButton.Click();
            Tags.SendKeys(tag);
            Tags.SendKeys(Keys.Enter);
            Thread.Sleep(3000);

        }

        public String ValidateTagisAdded()
        {
            String text = MarketingTag.Text;
            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + text);
            return text;
        }
        public void EnterSkillExchange()
        {
            //selecting skill exchange
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            String skillExchangeValue = GlobalDefinitions.ExcelLib.ReadData(1, "Skill-Exchange");
            Thread.Sleep(5000);
            ShareSkillButton.Click();
            SkillExchange.SendKeys(skillExchangeValue);
            SkillExchange.SendKeys(Keys.Enter);
            Thread.Sleep(5000);

        }

        public String ValidateSkillExchangeIsAdded()
        {
            String text = PerformancetestingTag.Text;
            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + text);
            return text;
        }
        public void SelectSkillTrade()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            Thread.Sleep(5000);
            ShareSkillButton.Click();
            string skilltrade = GlobalDefinitions.ExcelLib.ReadData(1, "SkillTrade");
            if (skilltrade== "Skill-Exchange")
            {
                SkillExchangeRadiobutton.Click();
                Thread.Sleep(3000);

            }
            else
            {
                CreditRadioButton.Click();
            }
        }


        public bool SelectSkillTradeValidation()
        {
            return SkillExchangeRadiobutton.Selected;
        }



        public void Active()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            Thread.Sleep(6000);
            ShareSkillButton.Click();
            //Global.GlobalDefinitions.wait(15);

            string activeStatus = GlobalDefinitions.ExcelLib.ReadData(1, "Active");
            if (activeStatus == "Hidden")
            {
                HiddenRadioButton.Click();

                Thread.Sleep(3000);
            }

            else
            {
                ActiveRadioButton.Click();
                Thread.Sleep(3000);
            }
      
        }
       
        public bool ValidateActive()
        {
            return HiddenRadioButton.Selected;
        }


        


    }
   


}





        
    

        

        


       


    







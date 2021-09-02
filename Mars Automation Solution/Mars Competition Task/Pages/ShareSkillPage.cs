using System;
using System.Threading;
using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using AutoItX3Lib;
using System.Collections.Generic;
using System.Linq;

namespace Mars_Competition_Task.Pages
{
    class ShareSkillPage
    {

        public ShareSkillPage()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }

        //ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }


        //Title 
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")]
        private IWebElement Title { get; set; }

        //Description 
        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")]
        private IWebElement Description { get; set; }

        //Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Category 
        [FindsBy(How = How.XPath, Using = "//select[@name='categoryId']")]
        private IWebElement Category { get; set; }

        //Graphics and design
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[2]")]
        private IWebElement Categoryvalue { get; set; }

        //SubCategory Dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='subcategoryId']")]
        private IWebElement SubCategory { get; set; }
        //Book & Album covers
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[3]")]
        private IWebElement SubCategoryvalue { get; set; }

        //Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }

        //Service type
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        private IWebElement ServiceTypeOptions { get; set; }
        //onoffserviceradiobutton
        [FindsBy(How = How.XPath, Using = "//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]")]
        private IWebElement OneOffServiceRadioButton { get; set; }
        //HourlyServiceRadioButton
        [FindsBy(How = How.XPath, Using = "//div[5]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement HourlyServiceRadioButton { get; set; }
        //OnlineRadioButton
        //[FindsBy(How = How.Name, Using = "locationType")]
        [FindsBy(How = How.CssSelector, Using = "input[value='1'][name='locationType']")]
        private IWebElement OnlineRadioButton { get; set; }
        //OnsiteRadioButton
        [FindsBy(How = How.CssSelector, Using = "input[value='0'][name='locationType']")]
        private IWebElement OnsiteRadioButton { get; set; }


        //Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }
        //start date
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input")]
        private IWebElement StartDate { get; set; }
        //end date
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input")]
        private IWebElement EndDate { get; set; }
        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        //  private IWebElement Days { get; set; }
        private IWebElement Days { get; set; }
        //day checkbox
        [FindsBy(How = How.Name, Using = "Available")]
       private IList<IWebElement > DayCheckbox{ get; set; }
        
        //Monday
        
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input")]
        private IWebElement Monday { get; set; }
        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Start time' and @index='1']")]
        private IWebElement StartTime { get; set; }
        //Storing the starttime
        [FindsBy(How = How.Name, Using = "StartTime")]
        private IList<IWebElement> StartTimeList { get; set; }
        //Storing the endtime
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='End time' and @index='1']")]
        private IWebElement EndTime { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='twelve wide column']//div[2]//div[2]//input[1]")]
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
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }
        //Click on ActiveRadioButton option
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")]
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

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/span")]
        private IWebElement PerformanceTestingTag { get; set; }


        //Click on upload button
        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        //[FindsBy(How = How.XPath, Using = "i[@class='huge plus circle icon padding-25']")]
        private IWebElement WorksampleIcon { get; set; }

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }

        //sucess message save skill
        //[FindsBy(How = How.XPath, Using = "//div[Contains(text(),'Service Listing Added Successfully)']")]
        [FindsBy(How = How.XPath, Using = "//div[@class='ns-box-inner']")]
        private IWebElement SaveSuccess { get; set; }

        //1st Test case-user creates shareskill with single day
        public void CreateShareSkill()
        {
            ClickShareskillbutton();
            EnterTitle();
            EnterDescription();
            ClickOnCategory();
            SelectCategory();
            SelectSubCategory();
            EnterTags();
            SelectServiceType();
            SelectLocationType();
            EnterStartDate();
            EnterEndDate();
            SelectDay();
            EnterStartTime();
            EnterEndTime();
            SelectSkillTrade();
            EnterSkillExchange();
            Active();
            SaveSkills();
        }

        //user creates shareskill with Skill trade option as Creditradiobutton
        public void CreateShareSkillWithCreditRadioButton()
        {
            ClickShareskillbutton();
            EnterTitle();
            EnterDescription();
            ClickOnCategory();
            SelectCategory();
            SelectSubCategory();
            EnterTags();
            SelectServiceType();
            SelectLocationType();
            EnterStartDate();
            EnterEndDate();
            SelectDay();
            EnterStartTime();
            EnterEndTime();
            SelectCredit();
            EnterCredit();
            Active();
            SaveSkills();
        }

        //Adding skill in share skill page with group of days and time selected
        public void CreateShareSkillWithGroupOfDaysSelected()
        {
            ClickShareskillbutton();
            EnterTitle();
            EnterDescription();
            ClickOnCategory();
            SelectCategory();
            SelectSubCategory();
            EnterTags();
            SelectServiceType();
            SelectLocationType();
            EnterStartDate();
            EnterEndDate();
            SelectDays();
            SelectTimeForMultipleDays();
            SelectCredit();
            EnterCredit();
            Active();
            SaveSkills();
        }

        public void ClickShareskillbutton()
        {
            GlobalDefinitions.ElementExists("Link Text", "Share Skills", 7);
            ShareSkillButton.Click();
        }

        public void EnterTitle()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            string title = GlobalDefinitions.ExcelLib.ReadData(1, "Title");
            GlobalDefinitions.ElementExists("XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input", 4);
            Title.SendKeys(title);
        }

        public String TitleValidation()
        {

            GlobalDefinitions.ElementExists("XPath", "/html/body/div/div/div[1]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input", 4);
            string value = Title.GetAttribute("value");
            return value;
          
        }

        public String ValidateAtShareSkillPage()
        {
            MarsFramework.Global.GlobalDefinitions.ElementExists("LinkText", "Share Skill", 5);
            String ShareSkillButtontext = ShareSkillButton.Text;
            return ShareSkillButtontext;

        }
        public void EnterDescription()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");

            string description = GlobalDefinitions.ExcelLib.ReadData(1, "Description");

            Description.SendKeys(description);


        }
        public String ValidateDescription()
        {
            String text = Description.Text;
            
            return text;
        }
        public void ClickOnCategory()
        {
            GlobalDefinitions.ElementExists("Name", "categoryId", 5);
            CategoryDropDown.Click();

        }

        public void SelectCategory()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            String categoryDropDownValue = GlobalDefinitions.ExcelLib.ReadData(1, "Category");

            var selectElement = new SelectElement(CategoryDropDown);

            selectElement.SelectByText(categoryDropDownValue);


        }

        public String ValidateSelectCategory()
        {
            String text = Categoryvalue.Text;
            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + text);
            return text;

        }

        public void SelectSubCategory()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            String subCategoryDropDownValue = GlobalDefinitions.ExcelLib.ReadData(1, "Subcategory");
            SubCategory.Click();
            var selectElement = new SelectElement(SubCategory);


            selectElement.SelectByText(subCategoryDropDownValue);

        }
        public string ValidateSelectSubCategory()
        {
            String text = SubCategoryvalue.Text;
           
            return text;
        }
        
        public void EnterStartDate()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");

            int addDaysToStartDate = Convert.ToInt32(GlobalDefinitions.ExcelLib.ReadData(1, "AddDaysInCurrentDateToStart"));
            DateTime CurrentDate = DateTime.Now;
            GlobalDefinitions.ElementExists("XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input", 4);
            StartDate.Clear();
            
            string dateThen = CurrentDate.AddDays(addDaysToStartDate).ToString("dd/MM/yyyy");
            
            StartDate.SendKeys(CurrentDate.AddDays(addDaysToStartDate).ToString("dd/MM/yyyy"));
        }

        public String ValidateStartDate()
        {
            
            string value = StartDate.GetAttribute("value");
            
            return value;
        }
        public void EnterEndDate()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            int addDaysToStartDate = Convert.ToInt32(GlobalDefinitions.ExcelLib.ReadData(1, "AddDaysInCurrentDateToStart"));
            int addDaysToEndDate = Convert.ToInt32(GlobalDefinitions.ExcelLib.ReadData(1, "AddDaysInCurrentDateToEnd"));
            DateTime CurrentDate = DateTime.Now;
            GlobalDefinitions.ElementExists("XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input", 4);
            EndDate.Clear();
            if (addDaysToStartDate > addDaysToEndDate)
            {
                EndDate.SendKeys(CurrentDate.AddDays(addDaysToStartDate).ToString("dd/MM/yyyy"));
            }
            else
            {
                EndDate.SendKeys(CurrentDate.AddDays(addDaysToEndDate).ToString("dd/MM/yyyy"));
            }
        }


        public String ValidateEndDate()
        {
            string value = EndDate.GetAttribute("value");
            return value;
        }


        
        public void SelectDay()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            String day = (GlobalDefinitions.ExcelLib.ReadData(2, "Selectday"));
            
            GlobalDefinitions.ElementExists("XPath", "//div[@class='twelve wide column']//div[3]//div[1]//div[1]//input[1]", 6);

            Monday.Click();
            GlobalDefinitions.ElementExists("XPath", "//div[@class='twelve wide column']//div[3]//div[1]//div[1]//input[1]", 6);



        }

        public void Daysgroup()
        {
            int day = DayCheckbox.Count;
  

        }

        public bool ValidateSelectDay()
        {
            return Monday.Selected;
        }


        public void SelectDays()
        {
           
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            String days = (GlobalDefinitions.ExcelLib.ReadData(1, "Selectday"));

            GlobalDefinitions.ElementExists("Name", "Available", 5);

            
            Console.WriteLine("DAY >>>>>>>>>>>>>>>" + days);
            List<String> listOfDaysFromExcel = days.Split(',').ToList();
            Console.WriteLine("listOfDays >>>>>>>>>>>" + listOfDaysFromExcel);

            var daysToIndexMap = new Dictionary<string, string>();
            daysToIndexMap.Add("Sun","0");
            daysToIndexMap.Add("Mon", "1");
            daysToIndexMap.Add("Tue", "2");
            daysToIndexMap.Add("Wed", "3");
            daysToIndexMap.Add("Thu", "4");
            daysToIndexMap.Add("Fri", "5");
            daysToIndexMap.Add("Sat", "6");

            foreach (String day in listOfDaysFromExcel)
            {
                Console.WriteLine("day >>>>>>>>>>>" + day);                
                string indexValue = daysToIndexMap.GetValueOrDefault(day);//retrieve index value corresponding to day from excel test data.
                IWebElement dayToSelect = findWebElementUsingAttribute(DayCheckbox, "index", indexValue);
                dayToSelect?.Click();
                Thread.Sleep(2000);
            }

        }

        private static IWebElement findWebElementUsingAttribute(IList<IWebElement> webElementList, String attributeName, String attributeValue)
        {
            foreach (IWebElement webElement in webElementList)
            {
                if (webElement.GetAttribute(attributeName).Equals(attributeValue))
                {
                    Console.WriteLine("webElement found for index : "+ attributeValue);
                    return webElement;
                }
            }
            return null;
        }


        public void SelectTimeForMultipleDays()
        {
           // ClickShareskillbutton();

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            String days = (GlobalDefinitions.ExcelLib.ReadData(1, "Selectday"));
            GlobalDefinitions.ElementExists("Name", "Available", 5);
            List<String> listOfDaysFromExcel = days.Split(',').ToList();
            String StartTimeMultiple = (GlobalDefinitions.ExcelLib.ReadData(1, "Starttime"));
            List<String> listOfTimeFromExcel = StartTimeMultiple.Split(',').ToList();
            var daysToIndexMap = new Dictionary<string, string>();
            daysToIndexMap.Add("Sun", "0");
            daysToIndexMap.Add("Mon", "1");
            daysToIndexMap.Add("Tue", "2");
            daysToIndexMap.Add("Wed", "3");
            daysToIndexMap.Add("Thu", "4");
            daysToIndexMap.Add("Fri", "5");
            daysToIndexMap.Add("Sat", "6");
            Console.WriteLine("listOftime count >>>>>>>>>>>" + listOfTimeFromExcel.Count);
            foreach (String day in listOfDaysFromExcel)
            {
                Console.WriteLine("day >>>>>>>>>>>" + day);
                string indexValue = daysToIndexMap.GetValueOrDefault(day);//retrieve index value corresponding to day from excel test data.
                IWebElement startTimeToSelect = findWebElementUsingAttribute(StartTimeList, "index", indexValue);
                startTimeToSelect?.SendKeys(listOfTimeFromExcel[listOfDaysFromExcel.IndexOf(day)]);
                Thread.Sleep(2000);
            }
            

        }

       
        public void EnterStartTime()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            String startTime = GlobalDefinitions.ExcelLib.ReadData(1, "Starttime");
            Console.WriteLine("Start Time Value Before:" + StartTime.GetAttribute("value"));
            StartTime.SendKeys(startTime);            
        }

        public String ValidateStartTime()
        {
            GlobalDefinitions.ElementExists("XPath", "//input[@placeholder='Start time' and @index='1']", 4);
            string value = StartTime.GetAttribute("value");
            Console.WriteLine("Start Time Value After:" + value);
            return value;
        }
        public void EnterEndTime()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            String endTime = GlobalDefinitions.ExcelLib.ReadData(1, "Endtime");
            EndTime.SendKeys(endTime);

        }

        public String ValidateEndTime()
        {
            string value = EndTime.GetAttribute("value");
            Console.WriteLine("EndTime Value After:" + value);
            return value;
        }

        public void SaveSkills()
        {
            GlobalDefinitions.ElementExists("XPath", "//input[@value='Save']", 6);
            Save.Click();
            Thread.Sleep(5000);
            
        }

       
        public bool ValidateSkillTradeSkillExchangeRadioButton()
        {
            return SkillExchangeRadiobutton.Selected;
        }



        public String ValidateSkillTrade()
        {
            //skill exchange is selected
            String text = Description.Text;
            
            return text;
        }
        public String ValidateDescriptionEditting()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
           

            string description = GlobalDefinitions.ExcelLib.ReadData(2, "Description");
            GlobalDefinitions.ElementExists("XPath", "//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']", 4);
            Description.Clear();
            Description.SendKeys(description);

            String text = Description.Text;
            
            return text;

        }


        public void EditSkill()

        {
            //Description is editted in skill
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            GlobalDefinitions.ElementExists("XPath", "//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']", 4);
            Description.Clear();
            string description = GlobalDefinitions.ExcelLib.ReadData(2, "Description");
            Description.SendKeys(description);
            

        }

       public void FileUpload()
        {
            Thread.Sleep(5000);
            WorksampleIcon.Click();
            AutoItX3 autoIt = new AutoItX3();
            Thread.Sleep(2000);
            
            //Thread.Sleep(3000);
            autoIt.WinActivate("Open");
            autoIt.Send(@"C:\Users\nirur\Desktop\san\bugfile.png");
            Thread.Sleep(5000);
            autoIt.Send("{Enter}");

        }

        public void CloseDriver()
        {
            GlobalDefinitions.driver.Close();
        }

        public void SelectLocationType()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");

            string locationTypeOption = GlobalDefinitions.ExcelLib.ReadData(1, "LocationType");

            if (locationTypeOption == "On-site")
            {

                OnsiteRadioButton.Click();

            }

            else
            {

                OnlineRadioButton.Click();

            }

        }
        public bool validateOnsiteRadiobuttonSelected()
        {
            return OnsiteRadioButton.Selected;

        }

        public void SelectServiceType()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            string ServiceTypeOption = GlobalDefinitions.ExcelLib.ReadData(1, "ServiceType");
            if (ServiceTypeOption == "One-off service")
            {
                OneOffServiceRadioButton.Click();

            }

            else
            {

                HourlyServiceRadioButton.Click();

            }
        }

        public bool ValidateServiceType()
        {   //oneoffserviceradiobuttonisselected
            return OneOffServiceRadioButton.Selected;
        }

        public bool validateMondayCheckBoxIsChecked()
        {
            return Monday.Selected;
           
        }

        public void EnterTags()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            String tag = GlobalDefinitions.ExcelLib.ReadData(1, "Tag");
            Tags.SendKeys(tag);
            Tags.SendKeys(Keys.Enter);
           

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
            SkillExchange.SendKeys(skillExchangeValue);
            SkillExchange.SendKeys(Keys.Enter);


        }

        public String ValidateSkillExchangeIsAdded()
        {
            String text = PerformanceTestingTag.Text;
            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + text);
            return text;
        }

        //selecting skill exchange radiobutton in skill trade
        public void SelectSkillTrade()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");


            string skilltrade = GlobalDefinitions.ExcelLib.ReadData(1, "SkillTrade");
            if (skilltrade == "Skill-Exchange")
            {
                SkillExchangeRadiobutton.Click();


            }
            else
            {
                CreditRadioButton.Click();
            }
        }
        //selecting credit radiobutton in skill trade
        public void SelectCredit()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            string skilltrade = GlobalDefinitions.ExcelLib.ReadData(1, "Credit");
            if (skilltrade == "Skill-Exchange")
            {
                SkillExchangeRadiobutton.Click();


            }
            else
            {
                CreditRadioButton.Click();
            }
        }

        public void EnterCredit()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            string creditAmount = GlobalDefinitions.ExcelLib.ReadData(1, "Creditvalue");
            CreditAmount.Clear();
            CreditAmount.SendKeys(creditAmount);
        }

        public bool SelectSkillTradeValidation()
        {
            return SkillExchangeRadiobutton.Selected;

        }



        public void Active()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
       

            string activeStatus = GlobalDefinitions.ExcelLib.ReadData(1, "Active");
            if (activeStatus == "Active")
            {
                GlobalDefinitions.ElementExists("XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input", 6);
                ActiveRadioButton.Click();


            }

            else
            {
                HiddenRadioButton.Click();

            }

        }

        public bool ValidateActive()
        {
            return ActiveRadioButton.Selected;
        }

        public void NavigateToManageListPage()
        {
            manageListingsLink.Click();
        }


        public void NavigateToShareSkillPage()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            string url = GlobalDefinitions.ExcelLib.ReadData(1, "url");
            GlobalDefinitions.driver.Navigate().GoToUrl(url);


        }

        public String ValidateSaveSkills()
        {
            
            String saveSuccessText = SaveSuccess.Text;
            GlobalDefinitions.ElementExists("XPath", "//div[Contains(text(),'Service Listing Added Successfully)']", 6);
            
            return saveSuccessText;
        }

    }
}


   








        
    

        

        


       


    







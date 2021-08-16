using MarsFramework.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Competition_Task.Pages
{
    class ServiceDetailPage
    {

        public ServiceDetailPage()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }

        //page factory design pattern
        [FindsBy(How = How.XPath, Using = "//*[@id='service-detail-section']/div[2]/div/div[2]/div[2]/div[1]/div/div[1]/div/a")]
        private IWebElement ChatButton { get; set; }

       public string ValidateChatText()
        {
            GlobalDefinitions.ElementExists("XPath", "//*[@id='service-detail-section']/div[2]/div/div[2]/div[2]/div[1]/div/div[1]/div/a", 5);
            String ChatButtonText = ChatButton.Text;
            return ChatButtonText;
        }

        public void NavigateToServiceDetailPage()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ServiceDetail");
            string url = GlobalDefinitions.ExcelLib.ReadData(1, "url");
            GlobalDefinitions.driver.Navigate().GoToUrl(url);
        }



    }
}

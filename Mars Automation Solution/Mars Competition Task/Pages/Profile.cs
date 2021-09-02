
using MarsFramework.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;


namespace Mars_Competition_Task.Pages
{
    class Profile

    {
        public Profile()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }
     

        #region  Initialize Web Elements 
        //Finding the profile
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Profile']")]

        public IWebElement Profiletab { get; set; }
        

        //Validating if logged in successfully
        public bool ValidateLogin()
        {
            MarsFramework.Global.GlobalDefinitions.ElementExists("XPath", "//a[normalize-space()='Profile']", 6);
            //IWebElement profile = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[1]/div[1]/a[2]"));
            String expectedtitle = "Profile";
            String actualtitle = Profiletab.Text;
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

    }
}
#endregion

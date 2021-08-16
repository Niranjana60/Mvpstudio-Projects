//using MarsFramework.Config;
using Mars_Competition_Task.Pages;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
//using RelevantCodes.ExtentReports;
using System;

namespace MarsFramework.Global
{
    class Base
    {
        //private static readonly int FIREFOX = 1;
        private static readonly int CHROME = 2;
        private static readonly bool IsLogin = true;
        // private static  bool canLogin = true;

        #region To access Path from resource file

        public static int Browser = CHROME;
        public static String ExcelPath = "D:/mvpstudio/vscode/repos/mvpstudio/Mars Automation Solution/Mars Competition Task/TestData/TestData.xlsx"; //TODO:Add excel file path here
        public static string ScreenshotPath = "";
        public static string ReportPath = "";
        #endregion

        #region reports
        /*public static ExtentTest test;
        public static ExtentReports extent;*/
        #endregion

        #region setup and tear down
        [SetUp]
        public void Inititalize()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            switch (Browser)
            {

                case 1:
                    GlobalDefinitions.driver = new FirefoxDriver();
                    break;
                case 2:
                    GlobalDefinitions.driver = new ChromeDriver();
                    GlobalDefinitions.driver.Manage().Window.Maximize();
                    break;

            }

            #region Initialise Reports

            /* extent = new ExtentReports(ReportPath, false, DisplayOrder.NewestFirst);
             extent.LoadConfig(MarsResource.ReportXMLPath);*/

            #endregion
            // if (canLogin) {
            if (IsLogin)
            {
                SignIn loginobj = new SignIn();
                loginobj.LoginSteps();
                // canLogin = false;
            }
            else
            {
                SignUp obj = new SignUp();
                obj.register();
            }
        }
        [TearDown]
        public void TearDown()
        {
            /*// Screenshot
            String img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Report");//AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");
            test.Log(LogStatus.Info, "Image example: " + img);
            // end test. (Reports)
            extent.EndTest(test);
            / calling Flush writes everything to the log file (Reports)
            extent.Flush();*/

            // Close the driver :)            
            GlobalDefinitions.driver.Close();
            //GlobalDefinitions.driver.Quit();
            //}
            #endregion

            ////}
        }
    }
}




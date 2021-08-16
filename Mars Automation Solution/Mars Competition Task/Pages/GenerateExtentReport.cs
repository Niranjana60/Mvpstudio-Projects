using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mars_Competition_Task.Pages
{
   public class GenerateExtentReport
    {
        private static ExtentReports extentReports;
        public static ExtentHtmlReporter htmlReporter;
       

        private GenerateExtentReport()
        {

        }

        
        public static ExtentReports getInstance()
        {
            if (extentReports == null)
            {

                String reportpath = @"D:\mvpstudio\vscode\repos\mvpstudio\Mars Automation Solution\Mars Competition Task\Extent Reports\Reports.html";
                htmlReporter = new ExtentHtmlReporter(reportpath);
                extentReports = new ExtentReports();
                extentReports.AttachReporter(htmlReporter);
                extentReports.AddSystemInfo("OS", "Windows");
                extentReports.AddSystemInfo("Host Name", "NIRANJANA");
                extentReports.AddSystemInfo("Environment", "QA");
                extentReports.AddSystemInfo("UserName", "sid");

                string extentConfigPath = @"D:\mvpstudio\vscode\repos\mvpstudio\Mars Automation Solution\Mars Competition Task\Extent Reports\extent-reports-conf.xml";
                htmlReporter.LoadConfig(extentConfigPath);

            }
            return extentReports;
        }
    }
        
        
}

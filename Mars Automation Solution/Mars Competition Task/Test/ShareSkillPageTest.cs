using Mars_Competition_Task.Pages;
using NUnit.Framework;
using System;
using System.IO;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace MarsFramework
{
    public class ShareSkillPageTest
    {

        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {
            ExtentReports rep = GenerateExtentReport.getInstance();
            ExtentTest test;

            [Test]
            public void CreateShareSkills()
            {

                    test = rep.CreateTest(TestContext.CurrentContext.Test.Name).Info("Test started");
                    test.Log(Status.Info, "Starting the ShareSkillPageTest");

                    

                    ShareSkillPage obj = new ShareSkillPage();
                    obj.CreateShareSkill();
                    test.Log(Status.Pass, "test passed");
                    rep.Flush();

                }

            [Test]

            public void CreateShareSkillsWithSkillTradeOptionAsCredit()
            {
                    test = rep.CreateTest(TestContext.CurrentContext.Test.Name).Info("Test started");
                    test.Log(Status.Info, "Starting the ShareSkillPageTestWithCreditRadioButton");
                    ShareSkillPage obj = new ShareSkillPage();

                    obj.CreateShareSkillWithCreditRadioButton();
                    test.Log(Status.Pass, "test passed");
                    rep.Flush();
            }

            [Test]
            public void CreateShareSkillsWithGroupOfDays()
            {
                ShareSkillPage obj = new ShareSkillPage();
                obj.CreateShareSkillWithGroupOfDaysSelected();
            }



            [Test]
            public void ValidatingTitleText()
            {

                ShareSkillPage obj = new ShareSkillPage();
                obj.ClickShareskillbutton();

                obj.EnterTitle();
                string value = obj.TitleValidation();


                Assert.AreEqual("Title is Entered", value);
            }

            [Test]
            public void ValidateDescription()
            {

                ShareSkillPage obj = new ShareSkillPage();
                obj.ClickShareskillbutton();
                obj.EnterDescription();


                string Text = obj.ValidateDescription();
                Assert.AreEqual("cccc cccc", Text);
            }

            [Test]
            public void ValidateCategory()
            {
                ShareSkillPage obj = new ShareSkillPage();
                obj.ClickShareskillbutton();
                obj.ClickOnCategory();
                obj.SelectCategory();

                string text = obj.ValidateSelectCategory();
                Assert.AreEqual("Graphics & Design", text);
            }

            [Test]
            public void ValidateSubCategory()
            {
                ShareSkillPage obj = new ShareSkillPage();
                obj.ClickShareskillbutton();
                obj.ClickOnCategory();
                obj.SelectCategory();
                obj.SelectSubCategory();

                string text = obj.ValidateSelectSubCategory();
                Assert.AreEqual("Book & Album covers", text);
            }

            [Test]
            public void ValidateTagIsAdded()
            {

                ShareSkillPage obj = new ShareSkillPage();
                obj.ClickShareskillbutton();

                obj.EnterTags();
                String text = obj.ValidateTagisAdded();
                Assert.AreEqual("Marketing×", text);


            }

            [Test]
            public void ValidateServiceTypeTest()
            {
                ShareSkillPage obj = new ShareSkillPage();
                obj.ClickShareskillbutton();
                obj.SelectServiceType();

                obj.ValidateServiceType();
                Assert.AreEqual(true, obj.ValidateServiceType());

            }

            [Test]
            public void ValidateSelectLocationType()
            {

                ShareSkillPage obj = new ShareSkillPage();
                obj.ClickShareskillbutton();

                obj.SelectLocationType();
                obj.validateOnsiteRadiobuttonSelected();
                Assert.AreEqual(true, obj.validateOnsiteRadiobuttonSelected());

            }
           

            [Test]
            public void ValidateSelectMonday()
            {
                ShareSkillPage obj = new ShareSkillPage();
                obj.ClickShareskillbutton();

                obj.SelectDay();
                bool text = obj.validateMondayCheckBoxIsChecked();
                Assert.AreEqual(true, obj.validateMondayCheckBoxIsChecked());


            }
            [Test]
            public void ValidateStartTimeSelection()
            {
                ShareSkillPage obj = new ShareSkillPage();
                obj.ClickShareskillbutton();
                obj.EnterStartTime();

                String text = obj.ValidateStartTime();

                Assert.AreEqual("10:00", text);
            }

            [Test]
            public void ValidateEndTimeSelection()
            {
                ShareSkillPage obj = new ShareSkillPage();
                obj.ClickShareskillbutton();
                obj.EnterEndTime();

                String text = obj.ValidateEndTime();


                Assert.AreEqual("11:00", text);
            }

            [Test]
            public void ValidateShareSkillPageValidation()
            {
                ShareSkillPage obj = new ShareSkillPage();
                obj.ClickShareskillbutton();
                string Text = obj.ValidateAtShareSkillPage();
                Assert.AreEqual("Share Skill", Text);
            }

            [Test]
            public void ValidateSkillTradeSelection()
            {

                ShareSkillPage obj = new ShareSkillPage();
                obj.ClickShareskillbutton();
                obj.SelectSkillTrade();
                obj.SelectSkillTradeValidation();

                Assert.AreEqual(true, obj.ValidateSkillTradeSkillExchangeRadioButton());
            }

            [Test]
            public void ValidateEnterSkillExchange()
            {

                ShareSkillPage obj = new ShareSkillPage();
                obj.ClickShareskillbutton();
                obj.EnterSkillExchange();

                string text = obj.ValidateSkillExchangeIsAdded();

                Assert.AreEqual("Performance Testing×", text);

            }


            [Test]
            public void ValidateActive()
            {
                ShareSkillPage obj = new ShareSkillPage();
                obj.ClickShareskillbutton();
                obj.Active();
                obj.ValidateActive();

                Assert.AreEqual(true, obj.ValidateActive());


            }


            //[Test]
            //public void AutoItTest()
            //{
            //    ShareSkillPage obj = new ShareSkillPage();
            //    obj.ClickShareskillbutton();
            //    obj.FileUpload();
            //    ////obj.SaveSkills();

            //}

        }
    }
}




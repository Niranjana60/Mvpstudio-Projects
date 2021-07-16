using Mars_Competition_Task.Pages;
using NUnit.Framework;
using System;

namespace MarsFramework
{
    public class TestRunner
    {

        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test]
            public void LoginTest()
            {

                SignIn loginobj = new SignIn();
                loginobj.LoginSteps();

            }

            [Test]
            public void LoggedInValidation()
            {
                SignIn loginobj = new SignIn();
                loginobj.LoginSteps();
                Profile profileobj = new Profile();
                profileobj.ValidateLogin();

                bool isloggedin = profileobj.ValidateLogin();
                Assert.IsTrue(isloggedin);


            }
        [Test]
            public void TitleEntry()
            {
                ShareSkillPage obj = new ShareSkillPage();
                obj.EnterTitle();

            }

           

            [Test]
            public void EnterDescription()
            {
                ShareSkillPage obj = new ShareSkillPage();
                obj.clickShareskillbutton();
                obj.EnterDescription();

            }

            [Test]
            public void ValidatingTitleText()
            {

                ShareSkillPage obj = new ShareSkillPage();

                obj.EnterTitle();
               

                Assert.AreEqual("Title is Entered", obj.TitleValidation());
            }

            [Test]
            public void DescriptionValidation()
            {
               
                ShareSkillPage obj = new ShareSkillPage();
                obj.EnterDescription();
                

                string Text = obj.ValidateDescription();
                Assert.AreEqual("cccc cccc", Text);
            }

            public void EdittedSkillValidation()
            {
                SignIn loginobj = new SignIn();
                loginobj.LoginSteps();
                ShareSkillPage obj = new ShareSkillPage();
                obj.clickShareskillbutton();
                obj.EditSkill();
                string Text = obj.ValidateDescriptionEditting();

                Assert.AreEqual("Description editted", Text);
            }

            [Test]
            public void SelectLocation()
            {
                SignIn loginobj = new SignIn();
                loginobj.LoginSteps();

                ShareSkillPage obj = new ShareSkillPage();
              
                obj.SelectLocationType();
                

            }

            [Test]
            public void ServiceTypeTest()
            {
                ShareSkillPage obj = new ShareSkillPage();
                obj.SelectServiceType();
   
            }

            [Test]
            public void ValidateServiceTypeSelection()
            {
                ShareSkillPage obj = new ShareSkillPage();
                obj.SelectServiceType();
                obj.ValidateServiceType();
                Assert.AreEqual(true, obj.ValidateServiceType());
            }


            [Test]
            public void ShareSkillPageValidation()
            {
                SignIn loginobj = new SignIn();
                loginobj.LoginSteps();
                ShareSkillPage obj = new ShareSkillPage();
                string Text = obj.ValidateAtShareSkillPage();
                Assert.AreEqual("Share Skill", Text);
            }
            [Test]
            public void SkillTradeSelection()
            {
                
                ShareSkillPage obj = new ShareSkillPage();
                obj.SelectSkillTrade();
            }
            [Test]
            public void ValidateSkillTradeSelectionSkillExchange()
            {

                ShareSkillPage obj = new ShareSkillPage();
                obj.SelectSkillTrade();

                Assert.AreEqual(true, obj.ValidateSkillTradeSkillExchangeRadioButton());
            }
            [Test]
            public void ValidateSkillIsEditted()
            {
                //Description is editted 
                SignIn loginobj = new SignIn();
                loginobj.LoginSteps();

                ShareSkillPage obj = new ShareSkillPage();
                String text = obj.ValidateDescriptionEditting();

                Assert.AreEqual("Description editted", text);
            }


                [Test]
            public void DeleteSkillTest()
            {
                SignIn loginobj = new SignIn();
                loginobj.LoginSteps();
                ManageListing manageListingobj = new ManageListing();

                manageListingobj.ClickOnManageListings();
                manageListingobj.DeleteSkill();

            }

            [Test]
            public void ValidateSkillisDeleted()
            {
                SignIn loginobj = new SignIn();
                loginobj.LoginSteps();              
                ManageListing manageListingObj = new ManageListing();
                manageListingObj.DeleteSkillValidation();
                
            }

            [Test]
            public void TagisAdded()
            {
                SignIn loginobj = new SignIn();
                loginobj.LoginSteps();
                ShareSkillPage obj = new ShareSkillPage();
                
                obj.EnterTags();

            }
            [Test]
            public void SkillExchangeAdding()
            {
               
                ShareSkillPage obj = new ShareSkillPage();

                obj.EnterSkillExchange();

            }
            [Test]
            public void ValidateSkillExchangeIsAdded()
            {

                ShareSkillPage obj = new ShareSkillPage();
                obj.EnterSkillExchange();

                obj.ValidateSkillExchangeIsAdded();

            }

            [Test]
            public void SaveSkillsTest()
            {
                ShareSkillPage obj = new ShareSkillPage();
                obj.SaveSkills();
            }

            [Test]
        public void Active()
        {
            ShareSkillPage obj = new ShareSkillPage();
            obj.Active();
        }

            [Test]
            public void ValidateActive()
            {
                ShareSkillPage obj = new ShareSkillPage();
                obj.Active();
                obj.ValidateActive();
            }

            [Test]
            public void TagValidation()
            {
                ShareSkillPage obj = new ShareSkillPage();
                obj.EnterTags();
                obj.ValidateTagisAdded();
            }

            [Test]
            public void SelectCategory()

            {
                ShareSkillPage obj = new ShareSkillPage();
                obj.ClickOnCategory();
                obj.SelectCategory();
            }

            [Test]
            public void SelectSubCategory()

            {
                ShareSkillPage obj = new ShareSkillPage();
                obj.ClickOnCategory();
                obj.SelectCategory();
                obj.ClickOnSubCategory();
                obj.SelectSubCategory();
            }


            [Test]
            public void ViewActions()
            {

                SignIn loginobj = new SignIn();
                loginobj.LoginSteps();
                ManageListing manageListingobj = new ManageListing();
                //Profile profilePageObj = new Profile();
                manageListingobj.ClickOnManageListings();
                manageListingobj.Clickoneyeicon();
                // manageListingobj.Navigate("url");


                //ServiceDetail serviceDetailobj = new ServiceDetail();
                //serviceDetailobj.EnterChatMessages();


            }
            [Test]
            public void ValidateViewAction()
            {
                ManageListing manageListingobj = new ManageListing();
                manageListingobj.ClickOnManageListings();
                manageListingobj.Clickoneyeicon();
                manageListingobj.ValidateView();

                //Assert.AreEqual(true, manageListingobj.ValidateView());



            }
            [Test]
            public void ValidateLocationSelection()
            {
                ShareSkillPage shareSkill = new ShareSkillPage();
               
                shareSkill.SelectLocationType();


                Assert.AreEqual(true, shareSkill.validateOnsiteRadiobuttonSelected());
            }
        }

        

        
        




    }
}




using Mars_Competition_Task.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Competition_Task.Test
{
    [TestFixture]
    class ManageListingTest : MarsFramework.Global.Base
    {
        [Test,Order(1)]
        //1st Test case:View Manage Listing Details
        public void ViewManageListing()
        {
            ManageListingPage obj = new ManageListingPage();
            obj.ClickOnManageListingsLink();
            obj.ClickManageListingEyeIcon();

            ServiceDetailPage servicedetailpageobj = new ServiceDetailPage();
            String text = servicedetailpageobj.ValidateChatText();
            Assert.AreEqual("Chat", text);
        }

        [Test,Order(2)]
        // 2nd Test :Edit Manage Listing Details
        public void EditManageListings()
        {
            ManageListingPage obj = new ManageListingPage();
            obj.ClickOnManageListingsLink();
            obj.ClickOnEditLinkIcon();

            ShareSkillPage shareskillobj = new ShareSkillPage();
            //shareskillobj.CreateShareSkill();
            shareskillobj.EditSkill();
            shareskillobj.SaveSkills();
            
           
        }

        [Test, Order(3)]
        public void ValidateEditManageListings()
        {
            ManageListingPage obj = new ManageListingPage();
            obj.ClickOnManageListingsLink();

            String text = obj.ValidateDescriptionIsEditted();
            Assert.AreEqual("Description editted", text);
        }

        //3rd Test case-Delete Manage Listing
        [Test, Order(4)] 
        public void DeleteManageListings()
        {
            ManageListingPage obj = new ManageListingPage();
            obj.ClickOnManageListingsLink();
            obj.DeleteSkill();

            String text = obj.ValidateDeleteSkill();
            Assert.AreEqual("Title is Entered has been deleted", text);


        }

        [Test, Order(5)]
        public void ValidateCategoryValue()
        {
            ManageListingPage obj = new ManageListingPage();
            obj.ClickOnManageListingsLink();
            String text = obj.ValidateCategory();
            Assert.AreEqual("Graphics & Design", text);
        }

        [Test, Order(6)]
        public void ValidateTitleValue()
        {
            ManageListingPage obj = new ManageListingPage();
            obj.ClickOnManageListingsLink();
            String text = obj.ValidateTitle();
            Assert.AreEqual("Title is Entered", text);

        }

        [Test, Order(7)]
        public void ValidateDescriptionValue()
        {
            ManageListingPage obj = new ManageListingPage();
            obj.ClickOnManageListingsLink();
            String text = obj.ValidateDescriptionValue();

            Assert.AreEqual("cccc cccc", text);

        }

        [Test,Order(8)]
        public void ValidateServiceTypeValue()
        {
            ManageListingPage obj = new ManageListingPage();
            obj.ClickOnManageListingsLink();

            String text = obj.ValidateServiceTypeValue();
            Assert.AreEqual("One-off", text);


        }

        [Test, Order(9)]
        public void ValidateSkillTradeBlueCircleIsEnabled()
        {
            ManageListingPage obj = new ManageListingPage();
            obj.ClickOnManageListingsLink();

            bool text = obj.ValidateSkillTrade();
            Assert.AreEqual(true, text);


        }

        [Test, Order(10)]
        public void ValidateActiveRadioButtonIsEnabled()
        {
            ManageListingPage obj = new ManageListingPage();
            obj.ClickOnManageListingsLink();

            bool text = obj.ValidateActive();
            Assert.AreEqual(true, text);


        }

       

    }
}

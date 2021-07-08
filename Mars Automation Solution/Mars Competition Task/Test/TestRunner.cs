using NUnit.Framework;

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

                MarsFramework.Pages.SignIn  loginobj = new Pages.SignIn();
                loginobj.LoginSteps();
                



            }

            [Test]
            public void ShareSkillEntryTest()
            {
                MarsFramework.Pages.SignIn loginobj = new Pages.SignIn();
                loginobj.LoginSteps();

                MarsFramework.Pages.ShareSkillNew obj = new Pages.ShareSkillNew();
                obj.EnterTitle();

                obj.SelectLocationType();




            }




            //[Test]
            //public void ShareskillTest()
            //{
            //    MarsFramework.Pages.SignIn loginobj = new Pages.SignIn();
            //    loginobj.LoginSteps();

            //    MarsFramework.Pages.ShareSkill obj = new Pages.ShareSkill();

            //    obj.EnterShareSkill();

            //}



        }
    }
}

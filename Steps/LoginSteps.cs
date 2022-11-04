using SeleniumCSharpNetCore.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumCSharpNetCore.Steps
{
    [Binding]
    public class LoginSteps : DriverHelper
    {

        HomePage homePage = new HomePage();
        LoginPage loginPage = new LoginPage();

        [Given(@"I navigate to applications")]
        public void GivenINavigateToApplications()
        {
            Driver.Navigate().GoToUrl("http://www.eaapp.somee.com/");
        }

        [Given(@"I click the log in link")]
        public void GivenIClickTheLogInLink()
        {
            

            homePage.ClickLogin();
        }


        [Given(@"I enter user usnername and password")]
        public void GivenIEnterUserUsnernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.EnterUserNameAPassword(data.UserName, data.Password);
        }

        [Given(@"I click Login")]
        public void GivenIClickLogin()
        {
            loginPage.ClickLogin();
        }

        [Then(@"I should see user logged in to the applications")]
        public void ThenIShouldSeeUserLoggedInToTheApplications()
        {
            Assert.That(homePage.IsLogOffVisible(), Is.True, "The log off button was not displayed.");
        }
    }

}

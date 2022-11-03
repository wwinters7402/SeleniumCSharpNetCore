using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V105.CSS;
using SeleniumCSharpNetCore.Pages;
using System.Security.Cryptography.X509Certificates;
//using SeleniumCSharpNetCore.CustomControl;



namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    {


       // public  IWebDriver Driver;

        [SetUp]
        public void Setup()
        {


            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
        }

        [Test]
        
        public void NavigateToWebsite()
        {
            
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
           
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            //CustomControl control = new CustomControl();
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");

           
            Console.WriteLine("Test1 has completed.");
            Assert.Pass();




        }

        [Test]

        public void LogIn()
        {

            Driver.Navigate().GoToUrl("http://www.eaapp.somee.com/");

            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();

            homePage.ClickLogin();
            loginPage.EnterUserNameAPassword("admin", "password");
            loginPage.ClickLogin();
            Assert.That(homePage.IsLogOffVisible(), Is.True, "The log off button was not displayed.");


            Console.WriteLine("Test1 has completed.");
            Assert.Pass();




        }

        [TearDown]

        public void CloseBrowser()
        {

            Driver.Close();

        }
    }
}
﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpNetCore.Pages
{
     class LoginPage : DriverHelper
    {
        IWebElement txtUserName => Driver.FindElement(By.Name("UserName"));
        IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
        IWebElement btnLogin => Driver.FindElement(By.CssSelector(".btn-default"));

        public void EnterUserNameAPassword(string userName, string password)
        {

            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            
        }

        public void ClickLogin()

        {

            btnLogin.Click();
        }

            

    }
}

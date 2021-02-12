using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_First_App
{
    class LoginPageObjects
    {

        [Obsolete]
        public LoginPageObjects()
        {
            PageFactory.InitElements(Properties.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement loginBtn { get; set; }

        [Obsolete]
        public EAPageObjects Login(String userName , String password)
        {
            ////Enter UserName
            txtUserName.SendKeys(userName);
            ////Enter Password
            txtPassword.SendKeys(password);
            ////Click on LoginBtn
            loginBtn.Submit();
            //Return to the EAPagePbjects
            return new EAPageObjects();
        }



    }


}

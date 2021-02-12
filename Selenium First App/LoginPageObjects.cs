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

        [FindsBy(How = How.XPath, Using = "//*[@id='i0116']")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Next']")]
        public IWebElement submitBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='i0118']")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Sign in']")]
        public IWebElement signIn { get; set; }

        [Obsolete]
        public void EnterUserName(String userName)
        {
            //Enter UserName
            txtUserName.SendKeys(userName);
            //Click on LoginBtn
            submitBtn.Clicks();
            //Return to the EAPagePbjects
            //return new EAPageObjects();
        }

        public void EnterPassword( String password)
        {
            //Enter Password
            txtPassword.SendKeys(password);
            //Click on LoginBtn
            signIn.Clicks();
            //Return to the EAPagePbjects
            //return new EAPageObjects();
        }
        
        



    }


}

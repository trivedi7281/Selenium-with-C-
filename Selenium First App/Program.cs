using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protractor;
using OpenQA.Selenium.Support.UI;

namespace Selenium_First_App
{



    class Program
    {

        public WebDriverWait waitTime;
        

        static void Main(String[] args)
        {

        }


        [SetUp]
        public void NavigateToURL()
        {
            Properties.driver = new ChromeDriver();
            Properties.ngdriver = new NgWebDriver(Properties.driver);
            //naviate to Url
            Properties.driver.Manage().Window.Maximize();
            Properties.driver.Manage().Cookies.DeleteAllCookies();
            waitTime= new WebDriverWait(Properties.driver, TimeSpan.FromSeconds(30));
            Properties.driver.Navigate().GoToUrl("https://login.microsoftonline.com/0abe8783-2c3e-4c42-9848-54e419bcdeb0/oauth2/v2.0/authorize?response_type=id_token&scope=user.read%20openid%20profile&client_id=08cad6e8-9985-4cad-810b-2dadf6fa42de&redirect_uri=https%3A%2F%2Fwaqbolp01.azurewebsites.net%2F&state=eyJpZCI6ImNkNzE0OTcxLWViY2EtNGJkYy04M2QyLTM3MWY2ODBiNmFhNiIsInRzIjoxNjEzMTM2Mzc4LCJtZXRob2QiOiJyZWRpcmVjdEludGVyYWN0aW9uIn0%3D&nonce=16236db8-94fc-40bf-8bae-94a1b2cb096a&client_info=1&x-client-SKU=MSAL.JS&x-client-Ver=1.3.2&client-request-id=d04395d1-bd00-43cb-8e3a-d0fdf865ba32&response_mode=fragment");
            Console.WriteLine("Navigated to the 'demo Home Page' URL Sucessfully");

        }

        [Test]
        [Obsolete]
        public void LoginIntoApplication()
        {
            //Intitialize the page by calling it reference
            LoginPageObjects Loginpage = new LoginPageObjects();
            Loginpage.EnterUserName("zedbxacp@bosbil.no");
            waitTime = new WebDriverWait(Properties.driver, TimeSpan.FromSeconds(30));
            Loginpage.EnterPassword("6d96E333yjB88ut");
            //EAPageObjects EAPage = Loginpage.Login("Execute", "automation");
            //EAPage.FillUserForm("" , "Akash", "Kumar");

            ////select title
            //setmethods.selectdropdown("titleid", locatortype.id, "mr.");
            //console.writeline("title selected:" + getmethods.getdropdownvalue("titleid", locatortype.id));
            ////initital
            //setmethods.entertext("initial", locatortype.name, "12");
            //console.writeline("entered initial:" + getmethods.gettext("initial", locatortype.name));
            ////firstname
            //setmethods.entertext("firstname", locatortype.id, "testing automation");
            //console.writeline("entered firstname:" + getmethods.gettext("firstname", locatortype.id));
            ////click on save
            //setmethods.click("save", locatortype.name);
            //console.writeline("clicked on save");
        }


        [TearDown]
        public void Close()
        {
           // Properties.driver.Close();
            //Console.WriteLine("Closed the Browser");
        }


    }
}

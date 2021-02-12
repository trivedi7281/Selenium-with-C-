using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_First_App
{



    class Program
    {
        

        static void Main(String[] args)
        {

        }


        [SetUp]
        public void NavigateToURL()
        {
            Properties.driver = new ChromeDriver();
            //naviate to Url
            Properties.driver.Manage().Window.Maximize();
            Properties.driver.Manage().Cookies.DeleteAllCookies();
            Properties.driver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html");
            Console.WriteLine("Navigated to the 'demo Home Page' URL Sucessfully");

        }

        [Test]
        [Obsolete]
        public void ExecuteTestCase()
        {
            //Intitialize the page by calling it reference
            LoginPageObjects Loginpage = new LoginPageObjects();
            EAPageObjects EAPage = Loginpage.Login("Execute", "automation");
            EAPage.FillUserForm("" , "Akash", "Kumar");

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
            Properties.driver.Close();
            Console.WriteLine("Closed the Browser");
        }


    }
}

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
        //Create the reference of our browser
        

        static void Main(String[] args)
        {

        }


        [SetUp]
        public void navigateToURL()
        {
            Properties.driver = new ChromeDriver();
            //naviate to Url
            Properties.driver.Manage().Window.Maximize();
            Properties.driver.Manage().Cookies.DeleteAllCookies();
            Properties.driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Navigated to the 'demo Home Page' URL Sucessfully");

        }

        [Test]
        public void findElement()
        {
            //Select Title
            SetMethods.SelectDropDown("TitleId", LocatorType.Id, "Mr.");
            Console.WriteLine("Title Selected:" + GetMethods.GetDropDownValue( "TitleId", LocatorType.Id));
            //Initital
            SetMethods.EnterText("Initial", LocatorType.Name, "12");
            Console.WriteLine("Entered Initial:" + GetMethods.GetText( "Initial", LocatorType.Name));
            //FirstName
            SetMethods.EnterText("FirstName", "id", "Testing Automation");
            Console.WriteLine("Entered FirstName:" + GetMethods.GetText( "FirstName", LocatorType.Id));
            //Click on Save
            SetMethods.Click("Save", LocatorType.Id);
            Console.WriteLine("Clicked on Save");
        }


        [TearDown]
        public void close()
        {
            Properties.driver.Close();
            Console.WriteLine("Closed the Browser");
        }


    }
}

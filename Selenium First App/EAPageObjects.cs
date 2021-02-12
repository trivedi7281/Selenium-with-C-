using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_First_App
{
    class EAPageObjects
    {
        [Obsolete]
        public EAPageObjects()
        {
            PageFactory.InitElements(Properties.driver, this);
        }


        [FindsBy(How = How.Id , Using="TitleId")]
       public IWebElement selectTitleID { get; set; }

        [FindsBy(How = How.Id, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }


        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement save { get; set; }


       
        public void FillUserForm(String initial, String firstName, String middleName)
        {
            ////Enter Initial
            txtInitial.EnterText(initial);
            
            ////Enter FirstName
            txtFirstName.EnterText(firstName);
            
            ////Enter MiddleName
            txtMiddleName.EnterText(middleName);
            
            ////Click on Save
            save.Clicks();
           

        }

    }

}

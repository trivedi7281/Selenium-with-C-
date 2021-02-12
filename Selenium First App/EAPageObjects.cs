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
       public IWebElement TitleID { get; set; }


        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement Initial { get; set; }

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement FirstName { get; set; }


        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement Save { get; set; }

    }

}

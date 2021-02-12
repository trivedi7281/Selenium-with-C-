using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Selenium_First_App
{
    public static class SetMethods
    {
        
        /// <summary>
        /// Extended Custom Method To Enter the Text 
        /// </summary>
        /// <param name="element"></param>
        /// <param name="Locator_Value"></param>
        public static void EnterText(this IWebElement element, String Locator_Value)
        {
            element.SendKeys(Locator_Value);

        }

        
        /// <summary>
        /// Custom Method To Click into a Button , checkbox, option etc. 
        /// </summary>
        /// <param name="element"></param>
        public static void Clicks(this IWebElement element)
        {
            element.Click();

        }

        /// <summary>
        /// Custom Method to Select a Dropdown Control
        /// </summary>
        /// <param name="element"></param>
        /// <param name="Locator_Value"></param>
        public static void SelectDropDown(this IWebElement element , String Locator_Value)
        {
            
           new SelectElement(element).SelectByText(Locator_Value);
           
        }


    }
}

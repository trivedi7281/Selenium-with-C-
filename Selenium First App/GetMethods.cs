using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_First_App
{
    public static class GetMethods
    {
        public static String GetText(this IWebElement element)
        {
            
         return element.GetAttribute("value");
           
        }

        public static String GetDropDownValue(this IWebElement element)
        {

            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
            
        }

    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_First_App
{
    class GetMethods
    {
        public static String GetText(String element, LocatorType Locator_Name)
        {
            if (Locator_Name == LocatorType.Id)
                return Properties.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (Locator_Name == LocatorType.Name)
                return Properties.driver.FindElement(By.Name(element)).GetAttribute("value");
            if (Locator_Name == LocatorType.XPath)
                return Properties.driver.FindElement(By.XPath(element)).GetAttribute("value");
            if (Locator_Name == LocatorType.Selector)
                return Properties.driver.FindElement(By.CssSelector(element)).GetAttribute("value");
            else return String.Empty;

        }

        public static String GetDropDownValue(String element, LocatorType Locator_Name)
        {
            if (Locator_Name == LocatorType.Id)
                return new SelectElement (Properties.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (Locator_Name == LocatorType.Name)
                return new SelectElement(Properties.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (Locator_Name == LocatorType.XPath)
                return new SelectElement(Properties.driver.FindElement(By.XPath(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (Locator_Name == LocatorType.Selector)
                return new SelectElement(Properties.driver.FindElement(By.CssSelector(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;

        }

    }
}

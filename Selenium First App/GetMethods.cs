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
        public static String GetText(String element, String Locator_Name)
        {
            if (Locator_Name == "id")
                return Properties.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (Locator_Name == "name")
                return Properties.driver.FindElement(By.Name(element)).GetAttribute("value");
            if (Locator_Name == "xpath")
                return Properties.driver.FindElement(By.XPath(element)).GetAttribute("value");
            if (Locator_Name == "cssSelector")
                return Properties.driver.FindElement(By.CssSelector(element)).GetAttribute("value");
            else return String.Empty;

        }

        public static String GetDropDownValue(String element, String Locator_Name)
        {
            if (Locator_Name == "id")
                return new SelectElement (Properties.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (Locator_Name == "name")
                return new SelectElement(Properties.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (Locator_Name == "xpath")
                return new SelectElement(Properties.driver.FindElement(By.XPath(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (Locator_Name == "cssSelector")
                return new SelectElement(Properties.driver.FindElement(By.CssSelector(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;

        }

    }
}

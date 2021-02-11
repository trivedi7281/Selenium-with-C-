using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Selenium_First_App
{
    class SetMethods
    {
        //Custom Method To Enter the Text 
        public static void EnterText(String element , String Locator_Name, String Locator_Value)
        {
            if (Locator_Name == "id")
                Properties.driver.FindElement(By.Id(element)).SendKeys(Locator_Value);
            if (Locator_Name == "name")
                Properties.driver.FindElement(By.Name(element)).SendKeys(Locator_Value);
            if (Locator_Name == "xpath")
                Properties.driver.FindElement(By.XPath(element)).SendKeys(Locator_Value);
            if (Locator_Name == "cssSelector")
                Properties.driver.FindElement(By.CssSelector(element)).SendKeys(Locator_Value);

        }

        //Custom Method To Click into a Button , checkbox, option etc. 
        public static void Click(String element, String Locator_Name)
        {
            if (Locator_Name == "id")
                Properties.driver.FindElement(By.Id(element)).Click();
            if (Locator_Name == "name")
                Properties.driver.FindElement(By.Name(element)).Click();
            if (Locator_Name == "xpath")
                Properties.driver.FindElement(By.XPath(element)).Click();
            if (Locator_Name == "cssSelector")
                Properties.driver.FindElement(By.CssSelector(element)).Click();

        }

        //Custom Method to Select a Dropdown Control
        public static void SelectDropDown(String element, String Locator_Name, String Locator_Value)
        {
            if (Locator_Name == "id")
                new SelectElement(Properties.driver.FindElement(By.Id(element))).SelectByText(Locator_Value);
            if (Locator_Name == "name")
                new SelectElement(Properties.driver.FindElement(By.Name(element))).SelectByText(Locator_Value);
            if (Locator_Name == "xpath")
                new SelectElement(Properties.driver.FindElement(By.XPath(element))).SelectByText(Locator_Value);
            if (Locator_Name == "cssSelector")
                new SelectElement(Properties.driver.FindElement(By.CssSelector(element))).SelectByText(Locator_Value);
        }


    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_First_App
{
    class Properties
    {
        public static IWebDriver driver{ get; set; }
    }


    enum LocatorType
    {
        Id, 
        Name,
        LinkText,
        XPath,
        CssName,
        ClassName,
        Selector
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;


namespace UnitTestProject3
{
    public class CommonMethods
    {
        public static IWebDriver driver;

        public CommonMethods()
        {
            //driver = new ChromeDriver();
        }

        public CommonMethods(string browsername)
        {
            if(browsername == "chrome")
            {
                driver = new ChromeDriver();
            }
            else if(browsername == "edge")
            {
                driver = new EdgeDriver();
            }
            driver.Manage().Window.Maximize();
        }
        public void myurlfun(string myweburl)
        {
            driver.Url = myweburl;
        }



        public IWebElement findelement(By path)
        {
            return driver.FindElement(path);
        }
        public void clickable_items(By path)
        {
            IWebElement clickitem = findelement(path);
            clickitem.Click();
        }
        public void chechkbox_item(By path)
        {
            IWebElement checkbx = findelement(path);
            checkbx.Click();
        }

        public void textfiled(By path , string mydata)
        {
            IWebElement text = findelement(path);
            text.SendKeys(mydata);

        }
        public void dropdownitem(By path ,string myvalue )
        {
            IWebElement mydrop= findelement(path);
            SelectElement mydropdown = new SelectElement(mydrop);
            mydropdown.SelectByValue(myvalue);
        }
        public void Search_Method(By Path,string myvalue)
        {
            IWebElement search_input= findelement(Path);
            search_input.SendKeys(myvalue);
        }

        public void nav_hover(By path)
        {
            IWebElement myelement=findelement(path);
            Actions myaction = new Actions(driver);
            myaction.MoveToElement(myelement).Build().Perform();
        }
    }
}

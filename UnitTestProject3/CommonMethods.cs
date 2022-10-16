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
        public void closedriver()
        {
            driver.Close();
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
            if (!checkbx.Selected)
            {
                checkbx.Click();
            }
        }

        public void textfiled(By path , string mydata)
        {
            IWebElement text = findelement(path);
            text.Clear();
            text.SendKeys(mydata);

        }
        public void dropdownitem(By path ,string myvalue )
        {
            IWebElement mydrop= findelement(path);
            SelectElement mydropdown = new SelectElement(mydrop);
            mydropdown.SelectByValue(myvalue);
        }
        public void dropdownitem_byindex(By path, int myvalue)
        {
            IWebElement mydrop = findelement(path);
            SelectElement mydropdown = new SelectElement(mydrop);
            mydropdown.SelectByIndex(myvalue);
        }

        public IWebElement explicitwaitelement(By path)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(path));
        }


        public void Search_Method(By Path,string myvalue)
        {
            IWebElement search_input= findelement(Path);
            search_input.SendKeys(myvalue);
        }
        public void scrollelement(By path)
        {
            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;
            IWebElement elementfind = findelement(path);
            scroll.ExecuteScript("arguments[0].scrollIntoView(true);", elementfind);
        }
        public void scrolltoelement_click(By path)
        {
            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;
            IWebElement elementfind = findelement(path);
            scroll.ExecuteScript("arguments[0].scrollIntoView(true);", elementfind);
            clickable_items(path);
        }
        public void scrolltoelement_textinput(By path,string mydata)
        {
            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;
            IWebElement elementfind = findelement(path);
            scroll.ExecuteScript("arguments[0].scrollIntoView(true);", elementfind);
            textfiled(path,mydata);
        }
        public void scrolltoelement_dropdown(By path, int mydata)
        {
            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;
            IWebElement elementfind = findelement(path);
            scroll.ExecuteScript("arguments[0].scrollIntoView(true);", elementfind);
            dropdownitem_byindex(path, mydata);
        }

        public void hover(By path)
        {
            IWebElement myelement=findelement(path);
            Actions myaction = new Actions(driver);
            myaction.MoveToElement(myelement).Build().Perform();
        }
    }
}

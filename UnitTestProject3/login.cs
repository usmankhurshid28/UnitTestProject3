using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject3
{
    public class login:CommonMethods
    {
        #region loginlocator

        By login_btn = By.XPath("//span[text()=' Sign In']");
        By email_login = By.Id("Email");
        By pass_login = By.Id("Password");
        By login_submit_btn = By.XPath("//input[@value='Log in']");

        #endregion
        public void loginFunctionality(string uName, string uPassword)
        {
            clickable_items(login_btn);
            textfiled(email_login, uName);
            textfiled(pass_login, uPassword);
            clickable_items(login_submit_btn);
        }
        
    }
}

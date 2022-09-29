using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        CommonMethods commonClassObj = new CommonMethods("chrome");
        public string URL = "https://pakautoparts.pk/";
        login loginObj = new login();
        searchfunctionality Sobj = new searchfunctionality();
        contactus Cobj = new contactus();
        navbar Nobj=new navbar();
       
        [TestMethod]
        public void loginExe()
        {
            loginObj.myurlfun(URL);
            loginObj.loginFunctionality();
        }

        [TestMethod]
        public void searchExc()
        {
            Sobj.myurlfun(URL);
            Sobj.searchfunc();
        }

        [TestMethod]
        public void contactExc()
        {
            Cobj.myurlfun(URL);
            Cobj.mycontact();
        }

        [TestMethod]
        public void navigationExc()
        {
            Nobj.myurlfun(URL);

            Nobj.accesri();
        }


    }
}

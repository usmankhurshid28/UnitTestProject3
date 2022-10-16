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
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);




        private TestContext testcontext;
        public TestContext TestContext
        {
            get { return testcontext; }
            set { testcontext = value; }
        }




        CommonMethods commonClassObj = new CommonMethods("chrome");
        public string URL = "https://pakautoparts.pk/";
        SignUpFunctionality SignupObj=new SignUpFunctionality();
        login loginObj = new login();
        searchfunctionality Sobj = new searchfunctionality();
        contactus Cobj = new contactus();
        navbar Nobj=new navbar();



        [TestMethod]
        public void registrationExc()
        {
            SignupObj.myurlfun(URL);
            SignupObj.RegistrationFunction();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML","logindata.xml","loginvalid" ,DataAccessMethod.Sequential)]
        public void loginfunction()
        {
            string userName = TestContext.DataRow["useremail"].ToString();
            string password = TestContext.DataRow["userpass"].ToString();
            loginObj.myurlfun(URL);
            loginObj.loginFunctionality(userName,password);
            Assert.AreEqual("muusmanlhr1@gmail.com", userName);
            Assert.AreEqual("test1234", password);
            Thread.Sleep(5000);
            //loginObj.closedriver();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "logindata.xml", "invalidlogin", DataAccessMethod.Sequential)]
        public void invlaidloginfunction()
        {
            string userName = TestContext.DataRow["useremail"].ToString();
            string password = TestContext.DataRow["userpass"].ToString();
            loginObj.myurlfun(URL);
            loginObj.loginFunctionality(userName, password);
            Assert.AreEqual("muusmanlhr1#gmail.com", userName);
            Assert.AreEqual("test1234", password);
            Thread.Sleep(5000);
            //loginObj.closedriver();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "logindata.xml", "emptyfieldlogin", DataAccessMethod.Sequential)]
        public void emptyfieldloginfunction()
        {
            string userName = TestContext.DataRow["useremail"].ToString();
            string password = TestContext.DataRow["userpass"].ToString();
            loginObj.myurlfun(URL);
            loginObj.loginFunctionality(userName, password);
            Thread.Sleep(5000);
            //loginObj.closedriver();
        }

        [TestMethod]
        public void searchExc()
        {
            Sobj.myurlfun(URL);
            Sobj.searchfunc();
        }


        [TestMethod]
        public void NavBarHoverExc()
        {
            Nobj.myurlfun(URL);
            Nobj.navbarhoverfunction();
        }


        [TestMethod]
        public void AccessoriesAddToWishlistExc()
        {
            Nobj.myurlfun(URL);
            Nobj.accessorieswishlistfunction();

        }
        [TestMethod]
        public void AccessoriesRemoveWishlistExc()
        {
            Nobj.myurlfun(URL);
            Nobj.accessorieswishlistRemovefunction();

        }

        [TestMethod]
        public void AccessoriesAddToCartExc()
        {
            Nobj.myurlfun(URL);
            Nobj.accessoriescartfunction();

        }

        [TestMethod]
        public void AccessoriesPurchaseProductExc()
        {
            Nobj.myurlfun(URL);
            Nobj.accessoriesPurchasefunction();

        }

        [TestMethod]
        public void contactExc()
        {
            Cobj.myurlfun(URL);
            Cobj.mycontact();
        }








    }
}

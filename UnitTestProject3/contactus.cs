using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProject3
{
    public class contactus : CommonMethods
    {
        #region contactuslocator
        By contact_btn = By.XPath("//a[text()='Contact us']");
        By C_full_name = By.Id("FullName");
        By C_phone_no = By.Id("cellnumber");
        By C_email = By.Id("Email");
        By C_message = By.Id("enq1");
        //C_catcpha
        By C_submit_btn = By.Name("send-email");

        #endregion

        public void mycontact()
        {
            clickable_items(contact_btn);
            textfiled(C_full_name, "Myname");
            textfiled(C_phone_no, "03102222340");
            textfiled(C_email, "muusmanlhr1@gmail.com");
            textfiled(C_message, "My message is ");
            Thread.Sleep(5000);
            scrolltoelement_click(C_submit_btn);

        }


    }
}

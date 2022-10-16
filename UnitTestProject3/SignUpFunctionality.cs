using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProject3
{

    public class SignUpFunctionality : CommonMethods
    {
        #region registeredloactaor

        By registered_btn = By.XPath("//span[text()='Register']");
        By gender = By.XPath("//span[@for='gender-male']");
        By first_name = By.Id("FirstName");
        By last_name = By.Id("LastName");
        By day_select = By.Name("DateOfBirthDay");
        By month_select = By.Name("DateOfBirthMonth");
        By year_select = By.Name("DateOfBirthYear");
        By email = By.Id("Email");
        By phone_no = By.Id("Phone");
        By checkbox = By.Id("Newsletter");
        By password = By.Id("Password");
        By confirm_pass = By.Id("ConfirmPassword");
        //Thread.Sleep(15000);
        By submit_reg = By.Id("register-button");

        #endregion

        public void RegistrationFunction()
        {
            clickable_items(registered_btn);
            clickable_items(gender);
            scrolltoelement_textinput(first_name,"Furqan");
            scrolltoelement_textinput(last_name, "Ahmed");
            scrolltoelement_dropdown(day_select, 3);
            scrolltoelement_dropdown(month_select, 5);
            scrolltoelement_dropdown(year_select, 88);
            scrolltoelement_textinput(email, "muusmanlhr2@gmail.com");
            scrolltoelement_textinput(phone_no, "03221234567");
            chechkbox_item(checkbox);
            scrolltoelement_textinput(password,"second123");
            scrolltoelement_textinput(confirm_pass, "second123");
            Thread.Sleep(20000);
            scrolltoelement_click(submit_reg);
        }
















    }

}

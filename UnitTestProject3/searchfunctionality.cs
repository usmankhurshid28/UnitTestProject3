using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProject3
{
    public class searchfunctionality : CommonMethods
    {
        By search_text_type = By.Id("q");
        By manufacture = By.Id("mid");
        By car_model = By.Id("cmodel");
        By car_year = By.Id("cyear");
        By search_button = By.XPath("//input[@value='Search']");
        By bumper = By.XPath("//a[text()=' Honda Vezel 2014-21 Front Bumper ']");
        By add_bumper_to_cart = By.Id("add-to-cart-button-4635");
        By shoping_btn = By.LinkText("shopping cart");
        By checkbox_termofservice = By.Id("termsofservice");
        By checkout_btn_click = By.XPath("//span[text()='Checkout']");
        By email_login = By.Id("Email");
        By pass_login = By.Id("Password");
        By login_submit_btn = By.XPath("//input[@value='Log in']");
        By new_adress = By.Name("billing_address_id");


        //By shoping_cart = By.ClassName("close");


        public void searchfunc()
        {
            textfiled(search_text_type,"Bumper");
            dropdownitem(manufacture, "2");
            Thread.Sleep(1000);
            dropdownitem(car_model, "3");
            dropdownitem(car_year, "2");
            scrolltoelement_click(search_button);
            scrolltoelement_click(bumper);
            scrolltoelement_click(add_bumper_to_cart);
            Thread.Sleep(2000);
            scrolltoelement_click(shoping_btn);
            Thread.Sleep(4000);
            chechkbox_item(checkbox_termofservice);
            Thread.Sleep(2000);
            scrolltoelement_click(checkout_btn_click);
            scrolltoelement_textinput(email_login, "muusmanlhr1@gmail.com");
            Thread.Sleep(1500);
            scrolltoelement_textinput(pass_login, "test1234");
            Thread.Sleep(1500);
            scrolltoelement_click(login_submit_btn);
            Thread.Sleep(2000);
            chechkbox_item(checkbox_termofservice);
            Thread.Sleep(1000);
            scrolltoelement_click(checkout_btn_click);
            Thread.Sleep(3000);
            dropdownitem_byitext(new_adress, "New Address");
            

        }
    }
}

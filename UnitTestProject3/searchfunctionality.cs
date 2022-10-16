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
        By shoping_cart = By.XPath("//*[@id='bar - notification']/div/span");


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
            scrolltoelement_click(shoping_cart);
        }
    }
}

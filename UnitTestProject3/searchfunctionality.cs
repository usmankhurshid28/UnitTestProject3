using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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


        public void searchfunc()
        {
            textfiled(search_text_type,"Camera");
            dropdownitem(manufacture, "2");
            dropdownitem(car_model, "2");
            dropdownitem(car_year, "2");
            clickable_items(search_button);
        }
    }
}

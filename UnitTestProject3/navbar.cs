using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject3
{
    public class navbar:CommonMethods
    {
        #region navbarlocator

        By Acces_nav = By.XPath("//span[text()='Accessories']");
        By acces_nav1 = By.XPath("//a[text()='Floor Mats ']");
         By Engi_and_part=By.XPath("//span[text()='Engine & Parts']");
        By nav_light = By.XPath("");
        #endregion

        public void accesri()
        {
            nav_hover(Acces_nav);
            clickable_items(acces_nav1);
        }





    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProject3
{
    public class navbar:CommonMethods
    {
        #region navbarlocator

        By Nav_Bar_Accessories = By.XPath("//span[text()='Accessories']");
        By Accessories_nav1 = By.XPath("//a[text()='Floor Mats ']");
        By opt_select = By.XPath("//a[text()=' Car Transparent Universal Matt (3pcs) ']");
        By addtowishlist = By.Id("add-to-wishlist-button-11898");
        By wishlisht_btn = By.LinkText("wishlist");
        By checkbox_removewishlist = By.XPath("//input[@type='checkbox' and @name='removefromcart' and @value='31968']");
        By updatewishlist = By.Name("updatecart");
        By addToCart_boxselect = By.XPath("//input[@type='checkbox' and @name='addtocart']");
        By addToCart_btn = By.Name("addtocartbutton");
        By termofservice_checkbox = By.Name("termsofservice");
        By checkout_btn = By.Name("checkout");
        By email_login = By.Id("Email");
        By pass_login = By.Id("Password");
        By login_submit_btn = By.XPath("//input[@value='Log in']");
        By Sameaddress_checkbox = By.Id("ShipToSameAddress");
        By billingAddress_FName = By.Id("BillingNewAddress_FirstName");
        By billingAddress_LName = By.Id("BillingNewAddress_LastName");
        By billingAddress_Company = By.Id("BillingNewAddress_Company");
        By billingAddress_country = By.Id("BillingNewAddress_CountryId");
        By billingAddress_city = By.Id("BillingNewAddress_City");
        By billingAddress_Address1 = By.Id("BillingNewAddress_Address1");
        By billingAddress_Address2 = By.Id("BillingNewAddress_Address2");
        By billingAddress_zipcode = By.Id("BillingNewAddress_ZipPostalCode");
        By billingAddress_phonenumber = By.Id("BillingNewAddress_PhoneNumber");
        By billingAddress_Continue_btn = By.XPath("//input[@type='button' and @title='Continue']");
        By shippingcontinue_btn = By.XPath("//input[@type='button' and @onclick='ShippingMethod.save()' and @value='Continue']");
        By paymentsave_btn = By.XPath("//input[@type='button' and @onclick='PaymentInfo.save()' and @value='Continue']");
        By confirmorder_btn = By.XPath("//input[@type='button' and @onclick='ConfirmOrder.save()' and @value='Confirm']");


        #endregion


        #region

        By Nav_Bar_Engi_and_part =By.XPath("//span[text()='Engine & Parts']");
        #endregion

        #region

        By Nav_Bar_Exterior = By.XPath("//span[text()='Exterior']");
        #endregion

        #region

        By Nav_Bar_Lights = By.XPath("//span[text()='Lights']");

        #endregion


        public void navbarhoverfunction()
        {
            hover(Nav_Bar_Accessories);
            hover(Nav_Bar_Engi_and_part);
            hover(Nav_Bar_Exterior);
            hover(Nav_Bar_Lights);
            hover(Nav_Bar_Exterior);
            hover(Nav_Bar_Engi_and_part);
            hover(Nav_Bar_Accessories);

        }
        public void accessorieswishlistfunction()
        
        {
            hover(Nav_Bar_Accessories);
            scrolltoelement_click(Accessories_nav1);
            hover(opt_select);
            scrolltoelement_click(opt_select);
            scrolltoelement_click(addtowishlist);
            Thread.Sleep(3000);
            scrolltoelement_click(wishlisht_btn);
            Thread.Sleep(2000);
            chechkbox_item(checkbox_removewishlist);

        }
        public void accessorieswishlistRemovefunction()

        {
            hover(Nav_Bar_Accessories);
            scrolltoelement_click(Accessories_nav1);
            scrolltoelement_click(opt_select);
            scrolltoelement_click(addtowishlist);
            scrolltoelement_click(wishlisht_btn);
            scrolltoelement_click(checkbox_removewishlist);
            scrolltoelement_click(updatewishlist);
            
        }
        public void accessoriescartfunction()

        {
            hover(Nav_Bar_Accessories);
            scrolltoelement_click(Accessories_nav1);
            scrolltoelement_click(opt_select);
            scrolltoelement_click(addtowishlist);
            scrolltoelement_click(wishlisht_btn);
            scrolltoelement_click(addToCart_boxselect);
            scrolltoelement_click(addToCart_btn);
        }

        public void accessoriesPurchasefunction()

        {
            hover(Nav_Bar_Accessories);
            scrolltoelement_click(Accessories_nav1);
            scrolltoelement_click(opt_select);
            scrolltoelement_click(addtowishlist);
            scrolltoelement_click(wishlisht_btn);
            scrolltoelement_click(addToCart_boxselect);
            scrolltoelement_click(addToCart_btn);
            scrolltoelement_click(termofservice_checkbox);
            scrolltoelement_click(checkout_btn);
            textfiled(email_login, "muusmanlhr2@gmail.com");
            textfiled(pass_login, "second123");
            scrolltoelement_click(login_submit_btn);
            scrolltoelement_click(termofservice_checkbox);
            scrolltoelement_click(checkout_btn);
            chechkbox_item(Sameaddress_checkbox);
            textfiled(billingAddress_FName,"Ahmed");
            textfiled(billingAddress_LName, "khan");
            textfiled(billingAddress_Company, "Ahmed Brothers");
            dropdownitem(billingAddress_country, "150");
            scrolltoelement_textinput(billingAddress_city, "lahore");
            scrolltoelement_textinput(billingAddress_Address1, "Johar Town");
            scrolltoelement_textinput(billingAddress_Address2, "A3");
            scrolltoelement_textinput(billingAddress_zipcode, "41000");
            scrolltoelement_textinput(billingAddress_phonenumber, "03124455766");
            scrolltoelement_click(billingAddress_Continue_btn);
            scrolltoelement_click(shippingcontinue_btn);
            scrolltoelement_click(paymentsave_btn);
            scrolltoelement_click(confirmorder_btn);
            
        }






    }
}

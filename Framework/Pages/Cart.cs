using System;

namespace Framework.Pages
{
    public class Cart
    {
        public static void ClickMenuItemElParduotuve()
        {
            string locator = "//*[@id='menu-item-42212']";
            Common.ClickElement(locator);
        }

        public static void ClickMenuItemDaile()
        {
            string locator = "//*[@class='cat-item cat-item-1860 cat-parent has-child']";
            Common.ClickElement(locator);
        }

        public static void ClickAngleDownIconPastele()
        {
            string locatorScrollIntoView = "//*[@class='cat-item cat-item-1906 cat-parent has-child']";
            string locator = "//*[@class='cat-item cat-item-1791 cat-parent has-child']//*[@class='icon-angle-down']";
            string script = "arguments[0].scrollIntoView(true);";
            Common.ExecuteJavascript(script, locatorScrollIntoView);
            Common.ClickElement(locator);
        }

        public static void ClickMenuItemAliejinePastele()
        {
            string locator = "//*[@id='woocommerce_product_categories-13']/ul/li[2]/ul/li[8]/ul/li[1]/a";
            string script = "arguments[0].scrollIntoView(true);";
            Common.ExecuteJavascript(script, locator);
            Common.ClickElement(locator);
        }

        public static void ClickCatalogueItemAliejinePastele12Spalvu()
        {
           // string locator = "(//*[@id='main']//*[@class='title-wrapper'])[1]";
            string locator = "(//*[@class='woocommerce-LoopProduct-link woocommerce-loop-product__link'])[1]";
           // string script = "arguments[0].scrollIntoView(true);";
            //Common.ExecuteJavascript(script, locator);
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }

        public static void IncreaseQuantityBy1()
        {
            string locator = "(//*[@class='plus button is-form'])[2]";
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }

        public static void ClickButtonIKrepseli()
        {
            string locator = "(//*[@class='single_add_to_cart_button button alt wp-element-button'])[2]";
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }

        public static bool CartIconWithLabel2Exists()
        {

            string locator = "(//*[@id='masthead']//*[@data-icon-label='2'])[1]";
            Common.WaitForElementToBeVisible(locator);
            return Common.ElementExists(locator);
        }

        public static bool CartIconWithLabel3Exists()
        {

            string locator = "(//*[@id='masthead']//*[@data-icon-label='3'])[1]";
            Common.WaitForElementToBeVisible(locator);
            return Common.ElementExists(locator);
        }

        public static string GetCartMessageItemsAdded()
        {
            string locator = "//*[@id='wrapper']/div/div";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }

        public static void ClickMenuItemDovanuKuponai()
        {
            string locator = "//*[@id='menu-item-74300']/a";
            Common.ClickElement(locator);
        }

        public static void ChooseDropdownMenuItem50Eur()
        {
            string locator = "//*[@id='gift-card-amount']";
            string option = "50.00€";
            Common.SelectFromDropdownMenu(locator, option);
        }

        public static void ClickCartIcon()
        {
            string locator = "//*[@id='masthead']//*[@class='icon-shopping-cart']";
            Common.ClickElement(locator);
        }

        public static void ClickFirstButtonXDelete()
        {
            string locator = "//*[@class='remove']";
            Common.ClickElement(locator);
        }

        public static string GetCartMessageEmptyCart()
        {
            string locator = "";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }
    }
}

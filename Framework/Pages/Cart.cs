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

        public static void ClickCatalogueItemByTitle(string itemTitle)
        {
            string locator = $"//*[contains(@class,'product-title')]//*[text()='{itemTitle}']";
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
            string locator = "//*[contains(@class,'form-normal')]//*[contains(@class,'single_add_to_cart_button')]";
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }

        //public static bool CartIconWithLabel2Exists()
        //{
        //    string locator = "(//*[@id='masthead']//*[@data-icon-label='2'])[1]";
        //    Common.WaitForElementToBeVisible(locator);
        //    return Common.ElementExists(locator);
        //}

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

            string locatorBody = "/html/body[@style='']";
            Common.WaitForElementToBeVisible(locatorBody);
        }

        public static void ChooseDropdownMenuItem50Eur()
        {
            string locator = "(//*[@id='gift-card-amount'])[2]";
            string option = "50.00€";
            Common.WaitForElementToBeVisible(locator);
            Common.SelectFromDropdownMenu(locator, option);
        }

        public static void ChooseDropdownMenuItem70Eur()
        {
            string locator = "(//*[@id='gift-card-amount'])[2]";
            string option = "70.00€";
            Common.WaitForElementToBeVisible(locator);
            Common.SelectFromDropdownMenu(locator, option);
        }

        public static void ClickCartIcon()
        {
            string locator = "//*[@id='masthead']//*[@class='icon-shopping-cart']";
            Common.ClickElement(locator);
        }

        public static void ClickFirstButtonXDelete()
        {
            string locator = "//*[@class='product-remove']//*[@data-product_id='72171']";
            Common.ClickElement(locator);
        }

        public static void ClickLastButtonXDelete()
        {
            string locatorButton = "//*[@class='product-remove']//*[@data-product_id='72171']";
            string locator = "//*[@class='woocommerce-cart-form']";
            Common.WaitForElementAttributeToNotContainValue(locator, "class", "processing");
            System.Threading.Thread.Sleep(5000);
            Common.ClickElement(locatorButton);
        }

        public static string GetCartMessageEmptyCart()
        {
            string locator = "//*[@class='cart-empty woocommerce-info']";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }
    }
}

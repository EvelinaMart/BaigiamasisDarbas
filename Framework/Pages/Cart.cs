namespace Framework.Pages
{
    public class Cart
    {
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



        

        public static void ClickCartIcon()
        {
            string locator = "//*[@id='masthead']//*[@class='icon-shopping-cart']";
            Common.ClickElement(locator);
        }

        public static void ClickRemoveFromCartButtonForItemByIndex(int itemIndex)
        {
            string locator = $"(//*[@class='product-remove'])[{itemIndex}]";
            int itemInCartCount = Common.GetItemCount("//*[@class='product-remove']");
            Common.ClickElement(locator);

            /* 
             * Cannot execute this wait if there are only one item in the cart
             * because after that item is removed, the form also does not exist anymore
             */
            if (itemInCartCount > 1)
            {
                Common.WaitForElementAttributeToNotContainValue(
                "//*[@class='woocommerce-cart-form']",
                "class",
                "processing");
            }
        }
        
        public static string GetCartMessageEmptyCart()
        {
            string locator = "//*[@class='cart-empty woocommerce-info']";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }
    }
}

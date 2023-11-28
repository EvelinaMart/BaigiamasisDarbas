namespace Framework.Pages
{
    public class Cart
    {
        





        //public static bool CartIconWithLabel2Exists()
        //{
        //    string locator = "(//*[@id='masthead']//*[@data-icon-label='2'])[1]";
        //    Common.WaitForElementToBeVisible(locator);
        //    return Common.ElementExists(locator);
        //}





        

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

namespace Framework.Pages
{
    public class Products
    {
        public class DovanuKuponai
        {
            public class Values
            {
                public static readonly string eur40 = "40.00€";
                public static readonly string eur50 = "50.00€";
                public static readonly string eur70 = "70.00€";
            }

            public static void SelectCouponValue(string value)
            {
                string locator = "//*[contains(@class,'form-normal')]//*[@id='gift-card-amount']";
                Common.WaitForElementToBeVisible(locator);
                Common.SelectFromDropdownMenu(locator, value);
            }
        }

        public class Categories
        {
            public static void ExpandCategoryByTitle(string title)
            {
                string locator = $"//*[contains(@class,'cat-item')]/a[text()='{title}']/../button";
                Common.ClickElement(locator);
            }

            public static void ClickCategoryByTitle(string title)
            {
                string locator = $"//*[contains(@class,'cat-item')]/a[text()='{title}']";
                Common.ClickElement(locator);
            }
        }

        public static void ClickItemByTitle(string itemTitle)
        {
            string locator = $"//*[contains(@class,'product-title')]//*[text()='{itemTitle}']";
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }

        public static void IncreaseQuantityBy1()
        {
            string locator = "//*[contains(@class,'form-normal')]//*[@class='plus button is-form']";
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }

        public static void ClickButtonIKrepseli()
        {
            string locator = "//*[contains(@class,'form-normal')]//*[contains(@class,'single_add_to_cart_button')]";
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }

        public static string GetCartMessageItemsAdded()
        {
            string locator = "//*[@id='wrapper']/div/div";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }
    }
}

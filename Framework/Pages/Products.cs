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

        public static void ClickButtonIKrepseli()
        {
            string locator = "//*[contains(@class,'form-normal')]//*[contains(@class,'single_add_to_cart_button')]";
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }
    }
}

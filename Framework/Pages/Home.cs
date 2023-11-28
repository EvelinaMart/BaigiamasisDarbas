namespace Framework.Pages
{
    public class Home
    {
        public static void Open()
        {
            Driver.OpenPage("https://ornamentai.lt/");
        }

        public static void CloseCookiesWindow()
        {
            string locator = "//*[@id='cn-accept-cookie']";
            Common.WaitForElementAttributeToNotContainValue(locator, "class", "cn-animated");
            Common.ClickElement(locator);
        }

        public static void ClickUserIcon()
        {
            string locator = "//*[@id='masthead']//*[@class='icon-user']";
            Common.ClickElement(locator);
        }
    }
}

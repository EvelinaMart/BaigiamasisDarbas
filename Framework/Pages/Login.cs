namespace Framework.Pages
{
    public class Login
    {
        public static void Open()
        {
            Driver.OpenPage("https://ornamentai.lt/");
        }

        public static void CloseCookiesWindow()
        {
            string locator = "//*[@id='cn-accept-cookie']";
            Common.ClickElement(locator);
        }

            public static void ClickUserIcon()
        {
            string locator = "//*[@id='masthead']//*[@class='icon-user']";
            Common.ClickElement(locator);
        }

            public static void EnterEmailAddress(string email)
        {
            string locator = "//*[@id='username']";
            Common.WaitForElementToBeVisible(locator);
            Common.SendKeysToElement(locator,email);
        }

        public static void EnterPassword(string password)
        {
            string locator = "//*[@id='password']";
            Common.SendKeysToElement(locator, password);
        }

        public static void ClickButtonPrisijungti()
        {
            string locator = "//*[@id='customer_login']//*[@value='Prisijungti']";
            Common.ClickElement(locator);
        }

        public static string UsernameVisibleAfterLogin()
        {
            string locator = "//*[@id='main']//*[@class='user-name inline-block']";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }

        public static string GetLoginErrorMessage()
        {
            string locator = "//*[@id='wrapper']//*[@class='message-container container alert-color medium-text-center']";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }
    }
}

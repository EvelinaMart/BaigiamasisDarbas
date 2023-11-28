namespace Framework.Pages
{
    public class Home
    {
        public class TopMenu
        {
            public static void ClickElParduotuve()
            {
                string locator = "//*[@id='menu-item-42212']";
                Common.ClickElement(locator);
            }

            public static void ClickDovanuKuponai()
            {
                string locator = "//*[@id='menu-item-74300']";
                Common.ClickElement(locator);

                string locatorBody = "/html/body[@style='']";
                Common.WaitForElementToBeVisible(locatorBody);
            }
        }

        public class MainMenu
        {
            public static void Open()
            {
                string locator = "//*[@id='masthead']//*[@class='icon-menu']";
                Common.WaitForElementToBeVisible(locator);
                Common.ClickElement(locator);
            }

            public static void ClickMenuItemEdukacijos()
            {
                string locator = "//*[@id='menu-item-85667']";
                string script = "arguments[0].scrollIntoView(true);";
                Common.WaitForElementToBeVisible(locator);
                Common.ExecuteJavascript(script, locator);
                Common.ClickElement(locator);
            }

            public static void ClickMenuItemTekstilesDekoravimas()
            {
                string locatorScrollIntoView = "//*[text()='EDUKACIJA – ŠILKO TAPYBA']";
                string locator = "//*[text()='EDUKACIJA – TEKSTILĖS DEKORAVIMAS']";
                string script = "arguments[0].scrollIntoView(true);";
                Common.ExecuteJavascript(script, locatorScrollIntoView);
                Common.ClickElement(locator);
            }

            public static void ClickButtonArrowToTheRight()
            {
                string locator = "//*[@id='nav-below']//*[@class='icon-angle-right']";
                string script = "arguments[0].scrollIntoView(true);";
                Common.ExecuteJavascript(script, locator);
                Common.ClickElement(locator);
            }

            public static string GetContactPhoneNumber()
            {
                string locator = "//*[@id=\"post-83331\"]/div/div/p[3]";
                Common.WaitForElementToBeVisible(locator);
                return Common.GetElementText(locator);
            }
        }

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

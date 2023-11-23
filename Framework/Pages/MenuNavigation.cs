namespace Framework.Pages
{
    public class MenuNavigation
    {
        
        public static void ClickButtonMenu()
        {
            string locator = "(//*[@class='icon-menu'])[2]";
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
            //string locatorScrollIntoView = "//*[text()='EDUKACIJA – TEKSTILĖS DEKORAVIMAS']";
            string locator = "//*[text()='EDUKACIJA – TEKSTILĖS DEKORAVIMAS']";
            string script = "arguments[0].scrollIntoView(true);";
            Common.ExecuteJavascript(script, locator);
            Common.ClickElement(locator);
        }

        public static void ClickButtonArrowToTheRight()
        {
            //string locatorScrollIntoView = "//*[@id='nav-below']//*[@class='icon-angle-right']";
            string locator = "//*[@id='nav-below']//*[@class='icon-angle-right']";
            string script = "arguments[0].scrollIntoView(true);";
            Common.ExecuteJavascript(script, locator);
            Common.ClickElement(locator);
        }

        public static string GetContactPhoneNumber()
        {
            string locator = "//*[@id=\"post-83331\"]/div/div/p[3]";
            //string locator = "//*[@id='post-83331']/div/div/p[3]/text()[1]";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }
    }
}

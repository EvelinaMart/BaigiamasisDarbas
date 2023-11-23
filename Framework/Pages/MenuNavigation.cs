﻿namespace Framework.Pages
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
}

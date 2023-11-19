using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;

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
            string locator = "//*[@id='masthead']/div[1]/div[3]/ul/li[1]";
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
            string locator = "//*[@id='customer_login']/div[1]/form/p[3]/button";
            Common.ClickElement(locator);
        }

        public static string usernameVisibleAfterLogin()
        {
            string locator = "//*[@id='main']/div[2]/div/div/div[1]/div/span[2]";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }

        //  public st   id ClickButtonInfo()
        // {
        //    string locator = "//*[@class='list-dropdown js-open-hover']";
        //    Common.ClickElement(locator);
        //}

        public static string GetErrorMessage()
        {
            string locator = "//*[@id='wrapper']/ul/li/div";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }
    }
}

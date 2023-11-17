using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;

namespace Framework.Pages
{
    public class Login
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.laisvalaikiodovanos.lt/vartotojas/prisijungti/");
        }
        
        public static void EnterEmailAddress(string email)
        {
            string locator = "//*[@id='login-form-email']";
            Common.SendKeysToElement(locator,email);
        }

        public static void EnterPassword(string password)
        {
            string locator = "//*[@id='login-form-pass']";
            Common.SendKeysToElement(locator, password);
        }

        public static void ClickMenuButtonPrisijungti()
        {
            string locator = "(//*[@class='login-colorbox'])[1]";
            Common.ClickElement(locator);
        }

        public static void ClickButtonPrisijungti()
        {
            string locator = "//*[@id='login-form']/section/div/div/div[4]/input";
            Common.ClickElement(locator);
        }

       /*public static IWebElement GetProfileIcon()
        *{
        *    string locator = "//*[@class='icon icon-user-2']";
        *    return Common.GetElement(locator);
        *}
        */

        public static bool ProfileIconExists()
        {
            string locator = "/html/body/header/div/nav/div/div[2]/div/ul[2]/li[4]/a";
            Common.WaitForElementToBeVisible(locator);
            return Common.ElementExists(locator);
        }

        public static string GetErrorMessageBody()
        {
            string locator = "/html/body/div[8]/div/ul/li";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }

        public static void ClickButtonInfo()
        {
            string locator = "//*[@class='list-dropdown js-open-hover']";
            Common.ClickElement(locator);
        }

        public static void CloseCookiesWindow()
        {
            string locator = "//*[@class='icon-remove-1']";
            Common.ClickElement(locator);
        }

        public static string GetErrorMessageTitle()
        {
            string locator = "//*[@id='floating-error-bg2']/div/p";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }
    }
}

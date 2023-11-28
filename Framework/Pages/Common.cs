using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Framework.Pages
{
    public class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        private static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }

        internal static int GetItemCount(string locator)
        {
            return GetElements(locator).Count;
        }

        internal static void ClickElement(string locator)
        {
            WaitForElementToBeVisible(locator);
            GetElement(locator).Click();
        }

        internal static void SendKeysToElement(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetElementText(string locator)
        {
            WaitForElementToBeVisible(locator);
            return GetElement(locator).Text;
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath(locator)));
        }

        internal static void WaitForElementAttributeToNotContainValue(string locator, string attributeName, string attributeValue)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            wait.Until(d => !d.FindElement(By.XPath(locator)).GetAttribute(attributeName).Contains(attributeValue));
        }

        internal static void SelectFromDropdownMenu(string locator, string option)
        {
            IWebElement dropdown = GetElement(locator);
            SelectElement select = new SelectElement(dropdown);
            select.SelectByText(option);
        }
    }
}

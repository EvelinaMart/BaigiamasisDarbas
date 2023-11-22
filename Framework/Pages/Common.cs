using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework.Pages
{
    public class Common
    {
        internal static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeysToElement(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static bool ElementExists(string locator)
        {
            try
            {
                IWebElement profileIcon = GetElement(locator);
                return true;
            }

            catch (NoSuchElementException)
            {
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath(locator)));
        }

            internal static void ExecuteJavascript(string script, string locator)
        {
            IWebElement element = GetElement(locator);
            ((IJavaScriptExecutor)Driver.GetDriver()).ExecuteScript(script, element);
        }

        internal static void WaitForElementAttributeToNotContainValue(string locator, string attributeName, string attributeValue)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
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

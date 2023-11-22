﻿using System;

namespace Framework.Pages
{
    public class Cart
    {
        public static void ClickMenuItemElParduotuve()
        {
            string locator = "//*[@id='menu-item-42212']";
            Common.ClickElement(locator);
        }

        public static void ClickMenuItemDaile()
        {
            string locator = "//*[@class='cat-item cat-item-1860 cat-parent has-child']";
            Common.ClickElement(locator);
        }

        public static void ClickAngleDownIconModeliavimasIrMaketavimas()
        {
            string locatorScrollIntoView = "//*[@class='cat-item cat-item-1904 cat-parent has-child']";
            string locator = "//*[@class='cat-item cat-item-1904 cat-parent has-child']//*[@class='icon-angle-down']";
            string script = "arguments[0].scrollIntoView(true);";
            Common.ExecuteJavascript(script, locatorScrollIntoView);
            Common.ClickElement(locator);
        }

        public static void ClickMenuItemSkulptura()
        {
            string locator = "//*[@class='cat-item cat-item-1853']";
            string script = "arguments[0].scrollIntoView(true);";
            Common.ExecuteJavascript(script, locator);
            Common.ClickElement(locator);
        }

        public static void ClickFirstOptionInCatalogue()
        {
            string locator = "(//*[@id='main']//*[@class='title-wrapper'])[1]";
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }

        public static void IncreaseQuantityBy1()
        {
            string locator = "(//*[@class='plus button is-form'])[2]";
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }

        public static void ClickButtonIKrepseli()
        {
            string locator = "(//*[@class='single_add_to_cart_button button alt wp-element-button'])[2]";
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }

        public static bool CartIconWithLabel2Exists()
        {

            string locator = "(//*[@id='masthead']//*[@data-icon-label='2'])[1]";
            Common.WaitForElementToBeVisible(locator);
            return Common.ElementExists(locator);
        }

        public static bool CartIconWithLabel3Exists()
        {

            string locator = "(//*[@id='masthead']//*[@data-icon-label='3'])[1]";
            Common.WaitForElementToBeVisible(locator);
            return Common.ElementExists(locator);
        }

        public static string GetCartMessageItemsAdded()
        {
            string locator = "//*[@id='wrapper']/div/div";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }

        public static void ClickMenuItemDovanuKuponai()
        {
            string locator = "//*[@id='menu-item-74300']/a";
            Common.ClickElement(locator);
        }

        public static void ChooseDropdownMenuItem50Eur()
        {
          //  throw new NotImplementedException();
        }

        public static void ClickCartIcon()
        {
            string locator = "//*[@id='masthead']//*[@class='icon-shopping-cart']";
            Common.ClickElement(locator);
        }

        public static void ClickFirstXButton()
        {
            string locator = "";
            Common.ClickElement(locator);
        }

        public static void ClickLastXButton()
        {
            string locator = "";
            Common.ClickElement(locator);
        }

        public static string GetCartMessageEmptyCart()
        {
            string locator = "";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }

        public static string ItemInCartTitle()
        {
            string locator = "(//*[@id='main']//*[@class='title-wrapper'])[1]";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }
    }
}
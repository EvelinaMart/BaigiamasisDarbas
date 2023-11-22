﻿using NUnit.Framework;
using Framework.Pages;

namespace Tests
{
    internal class CartScenario : BaseTest
    {
        [Test]

        public void AddingItemFromCatalogueToCart()
        {
            string expectedCartMessageItemsAdded = "2 × “Aliejinė pastelė ARTix Arts 12 spalvų” - įdėti į krepšelį";

            Cart.ClickMenuItemElParduotuve();
            Cart.ClickMenuItemDaile();
            Cart.ClickAngleDownIconPastele();
            Cart.ClickMenuItemAliejinePastele();
            Cart.ClickCatalogueItemAliejinePastele12Spalvu();
            Cart.IncreaseQuantityBy1();
            Cart.ClickButtonIKrepseli();

            Assert.That(Cart.CartIconWithLabel2Exists());
            Assert.That(Cart.GetCartMessageItemsAdded(), Is.EqualTo(expectedCartMessageItemsAdded));
        }

        [Test]

        public void AddingGiftVoucherToCart()
        {
            string expectedCartMessageVoucherAdded = "“Dovanų kuponas” - įdėtas į krepšelį";

            Cart.ClickMenuItemDovanuKuponai();
            Cart.ChooseDropdownMenuItem50Eur();
            Cart.ClickButtonIKrepseliGiftVoucher();

            Assert.That(Cart.CartIconWithLabel1Exists());
            Assert.That(Cart.GetCartMessageItemsAdded(), Is.EqualTo(expectedCartMessageVoucherAdded));
        }

        [Test]

        public void RemovingItemsFromCart()
        {
            string expectedcartmessage = "Krepšelis dar tuščias";

            Cart.ClickMenuItemDovanuKuponai();
            Cart.ChooseDropdownMenuItem50Eur();
            Cart.ClickButtonIKrepseliGiftVoucher();
            Cart.ChooseDropdownMenuItem70Eur();
            Cart.ClickButtonIKrepseli();
            Cart.ClickCartIcon();
            Cart.ClickFirstButtonXDelete();
            Cart.ClickLastButtonXDelete();

            Assert.That(Cart.GetCartMessageEmptyCart(), Is.EqualTo(expectedcartmessage));
        }
    }
}

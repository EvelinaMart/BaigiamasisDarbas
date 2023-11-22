using NUnit.Framework;
using Framework.Pages;

namespace Tests
{
    internal class CartScenario : BaseTestCart
    {
        [Test, Order(1)]

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

        [Test, Order(2)]

        public void AddingGiftVoucherToCart()
        {
            string expectedCartMessageVoucherAdded = "“Dovanų kuponas” - įdėtas į krepšelį";

            Cart.ClickMenuItemDovanuKuponai();
            Cart.ChooseDropdownMenuItem50Eur();
            Cart.ClickButtonIKrepseliGiftVoucher();

            Assert.That(Cart.CartIconWithLabel1Exists());
            Assert.That(Cart.GetCartMessageItemsAdded(), Is.EqualTo(expectedCartMessageVoucherAdded));
        }

        [Test, Order(3)]

        public void RemovingItemsFromCart()
        {
            string expectedCartMessage = "Krepšelis dar tuščias.";

            //Cart.ClickMenuItemDovanuKuponai();
            //Cart.ChooseDropdownMenuItem50Eur();
            //Cart.ClickButtonIKrepseliGiftVoucher();
            //Cart.ClickMenuItemDovanuKuponai();
            //Cart.ChooseDropdownMenuItem70Eur();
            //Cart.ClickButtonIKrepseliGiftVoucher();
            Cart.ClickCartIcon();
            Cart.ClickFirstButtonXDelete();
            Cart.ClickLastButtonXDelete();

            Assert.That(Cart.GetCartMessageEmptyCart(), Is.EqualTo(expectedCartMessage));
        }
    }
}

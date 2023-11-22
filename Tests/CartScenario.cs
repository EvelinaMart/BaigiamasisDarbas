using NUnit.Framework;
using Framework.Pages;

namespace Tests
{
    internal class CartScenario : BaseTest
    {
        [Test]

        public void AddingItemFromCatalogueToCart()
        {
            string expectedCartMessageItemsAdded = "“Aliejinė pastelė ARTix Arts 12 spalvų” - įdėtas į krepšelį";

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
            Cart.ClickButtonIKrepseli();

            Assert.That(Cart.CartIconWithLabel3Exists());
            Assert.That(Cart.GetCartMessageItemsAdded(), Is.EqualTo(expectedCartMessageVoucherAdded));
        }

        [Test]

        public void RemovingItemsFromCart()
        {
            string expectedCartMessage = "Krepšelis dar tuščias";

            Cart.ClickCartIcon();
            Cart.ClickFirstButtonXDelete();
            Cart.ClickFirstButtonXDelete();

            Assert.That(Cart.GetCartMessageEmptyCart(), Is.EqualTo(expectedCartMessage));
        }
    }
}

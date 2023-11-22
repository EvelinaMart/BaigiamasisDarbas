using NUnit.Framework;
using Framework.Pages;

namespace Tests
{
    internal class CartScenario : BaseTest
    {
        [Test]

        public void AddingItemFromCatalogueToCart()
        {
          //  string expectedCartMessageItemsAdded = ($"2 × \"{Cart.ItemInCartTitle}\" - įdėti į krepšelį");

            Cart.ClickMenuItemElParduotuve();
            Cart.ClickMenuItemDaile();
            Cart.ClickAngleDownIconModeliavimasIrMaketavimas();
            Cart.ClickMenuItemSkulptura();
            Cart.ClickFirstOptionInCatalogue();
            Cart.IncreaseQuantityBy1();
            Cart.ClickButtonIKrepseli();

            Assert.That(Cart.CartIconWithLabel2Exists());
          //  Assert.That(Cart.GetCartMessageItemsAdded(), Is.EqualTo(expectedCartMessageItemsAdded));
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
            Cart.ClickFirstXButton();
            Cart.ClickLastXButton();

            Assert.That(Cart.GetCartMessageEmptyCart(), Is.EqualTo(expectedCartMessage));
        }
    }
}

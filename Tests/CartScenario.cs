using NUnit.Framework;
using Framework.Pages;

namespace Tests
{
    internal class CartScenario : BaseTest
    {
        [Test]

        public void AddingItemsFromCatalogueToCart()
        {
            string expectedCartMessageItemsAdded = "2 × “Aliejinė pastelė ARTix Arts 12 spalvų” - įdėti į krepšelį";
            string itemTitle = "Aliejinė pastelė ARTix Arts 12 spalvų";

            Home.TopMenu.ClickElParduotuve();
            Products.Categories.ExpandCategoryByTitle("Dailė");
            Products.Categories.ExpandCategoryByTitle("Pastelė");
            Products.Categories.ClickCategoryByTitle("Aliejinė pastelė");
            Products.ClickItemByTitle(itemTitle);
            Products.IncreaseQuantityBy1();
            Products.ClickButtonIKrepseli();

            Assert.That(Products.GetCartMessageItemsAdded(), Is.EqualTo(expectedCartMessageItemsAdded));
        }

        [Test]

        public void RemovingItemsFromCart()
        {
            string expectedCartMessage = "Krepšelis dar tuščias.";

            Home.TopMenu.ClickDovanuKuponai();
            Products.DovanuKuponai.SelectCouponValue(Products.DovanuKuponai.Values.eur50);
            Products.ClickButtonIKrepseli();
            Home.TopMenu.ClickDovanuKuponai();
            Products.DovanuKuponai.SelectCouponValue(Products.DovanuKuponai.Values.eur70);
            Products.ClickButtonIKrepseli();
            Home.TopMenu.ClickDovanuKuponai();
            Products.DovanuKuponai.SelectCouponValue(Products.DovanuKuponai.Values.eur40);
            Products.ClickButtonIKrepseli();
            Cart.ClickCartIcon();
            Cart.ClickRemoveFromCartButtonForItemByIndex(1);
            Cart.ClickRemoveFromCartButtonForItemByIndex(1);
            Cart.ClickRemoveFromCartButtonForItemByIndex(1);

            Assert.That(Cart.GetCartMessageEmptyCart(), Is.EqualTo(expectedCartMessage));
        }
    }
}

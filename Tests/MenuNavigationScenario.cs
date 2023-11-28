using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
    internal class MenuNavigationScenario : BaseTest
    {
        [Test]

        public void ConfirmingCorrectContactDetailsInEducationCatalogue()
        {
            string expectedContactPhoneNumberText = "Susisiekite +370 630 20570\r\nParašykite info@ornamentai.lt";

            Home.MainMenu.Open();
            Home.MainMenu.ClickMenuItemByTitle("Edukacijos");
            Products.Edukacijos.ClickItemByTitle("EDUKACIJA – TEKSTILĖS DEKORAVIMAS");
            Products.Edukacijos.ClickButtonNextItem();

            Assert.That(Products.Edukacijos.GetContactPhoneNumber(), Is.EqualTo(expectedContactPhoneNumberText));
        }
    }
}

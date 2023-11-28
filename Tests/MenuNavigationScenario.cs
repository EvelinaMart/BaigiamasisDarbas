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
            Home.MainMenu.ClickMenuItemEdukacijos();
            Home.MainMenu.ClickMenuItemTekstilesDekoravimas();
            Home.MainMenu.ClickButtonArrowToTheRight();

            Assert.That(Home.MainMenu.GetContactPhoneNumber(), Is.EqualTo(expectedContactPhoneNumberText));
        }
    }
}

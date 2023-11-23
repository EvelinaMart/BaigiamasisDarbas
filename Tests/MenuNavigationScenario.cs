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

            MenuNavigation.ClickButtonMenu();
            MenuNavigation.ClickMenuItemEdukacijos();
            MenuNavigation.ClickMenuItemTekstilesDekoravimas();
            MenuNavigation.ClickButtonArrowToTheRight();

            Assert.That(MenuNavigation.GetContactPhoneNumber(), Is.EqualTo(expectedContactPhoneNumberText));
        }
    }
}

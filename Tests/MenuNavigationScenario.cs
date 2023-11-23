using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
    internal class MenuNavigationScenario : BaseTest
    {
        [Test]

        public void ConfirmingCorrectContactDetailsInTheEducationCatalogue()
        {
            string expectedContactPhoneNumberText = "Susisiekite +370 630 20570\r\nParašykite info@ornamentai.lt";

            MenuNavigation.ClickButtonMenu();
            MenuNavigation.ClickMenuItemEdukacijos();
            MenuNavigation.ClickMenuItemTekstilesDekoravimas();
            MenuNavigation.ClickButtonArrowTotheRight();

            Assert.That(MenuNavigation.GetContactPhoneNumber(), Is.EqualTo(expectedContactPhoneNumberText));
        }
    }
}

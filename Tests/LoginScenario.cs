using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
    internal class LoginScenario : BaseTest
    {
        [Test]

        public void LoginWithValidData()
        {
            string email = "email37589@gmail.com";
            string validPassword = "testinePaskyra7";
            string expectedUsernameVisibleAfterLogin = "email37589 #8346";

            Home.ClickUserIcon();
            Account.EnterEmailAddress(email);
            Account.EnterPassword(validPassword);
            Account.ClickButtonPrisijungti();

            Assert.That(Account.UsernameVisibleAfterLogin(), Is.EqualTo(expectedUsernameVisibleAfterLogin));
        }
        [Test]
        public void LoginWithInvalidData()
        {
            string email = "email37589@gmail.com";
            string invalidPassword = "testinePaskyra";
            string expectedLoginErrorMessage = "Klaida: Jūsų įvestas slaptažodis el. pašto adresui email37589@gmail.com yra neteisingas. Pamiršote slaptažodį?";

            Home.ClickUserIcon();
            Account.EnterEmailAddress(email);
            Account.EnterPassword(invalidPassword);
            Account.ClickButtonPrisijungti();

            Assert.That(Account.GetLoginErrorMessage(), Is.EqualTo(expectedLoginErrorMessage));
        }
    }
}

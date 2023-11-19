using Framework;
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

            Login.ClickUserIcon();
            Login.EnterEmailAddress(email);
            Login.EnterPassword(validPassword);
            Login.ClickButtonPrisijungti();

            Assert.That(Login.usernameVisibleAfterLogin(), Is.EqualTo(expectedUsernameVisibleAfterLogin));
        }
        [Test]
        public void LoginWithInvalidData()
        {
            string email = "email37589@gmail.com";
            string invalidPassword = "testinePaskyra";
            string expectedErrorMessage = "Klaida: Jūsų įvestas slaptažodis el. pašto adresui email37589@gmail.com yra neteisingas. Pamiršote slaptažodį?";

            Login.ClickUserIcon();
            Login.EnterEmailAddress(email);
            Login.EnterPassword(invalidPassword);
            Login.ClickButtonPrisijungti();

            Assert.That(Login.GetErrorMessage(), Is.EqualTo(expectedErrorMessage));
        }
    }
}

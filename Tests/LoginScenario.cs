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
            Login.EnterEmailAddress(email);
            Login.EnterPassword(validPassword);
            Login.ClickButtonPrisijungti();

            Assert.That(Login.UsernameVisibleAfterLogin(), Is.EqualTo(expectedUsernameVisibleAfterLogin));
        }
        [Test]
        public void LoginWithInvalidData()
        {
            string email = "email37589@gmail.com";
            string invalidPassword = "testinePaskyra";
            string expectedLoginErrorMessage = "Klaida: Jūsų įvestas slaptažodis el. pašto adresui email37589@gmail.com yra neteisingas. Pamiršote slaptažodį?";

            Home.ClickUserIcon();
            Login.EnterEmailAddress(email);
            Login.EnterPassword(invalidPassword);
            Login.ClickButtonPrisijungti();

            Assert.That(Login.GetLoginErrorMessage(), Is.EqualTo(expectedLoginErrorMessage));
        }
    }
}

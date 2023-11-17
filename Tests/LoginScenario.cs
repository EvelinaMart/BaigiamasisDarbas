using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
    internal class LoginScenario : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Login.Open();
        }
        [Test]

        public void LoginWithValidData()
        {
            string email = "email37589@gmail.com";
            string validPassword = "testinePaskyra3";

            Login.CloseCookiesWindow();
            // Login.ClickButtonInfo();
            // Login.ClickMenuButtonPrisijungti();
            Login.EnterEmailAddress(email);
            Login.EnterPassword(validPassword);
            Login.ClickButtonPrisijungti();

            Assert.That(Login.ProfileIconExists()); // Profile icon is visible
        }
        [Test]
        public void LoginWithInvalidData()
        {
            string email = "email37589@gmail.com";
            string invalidPassword = "testinePaskyra";
            string expectedErrorMessageTitle = "REGISTRACIJOS KLAIDA";
            string expectedErrorMessageBody = "Slaptažodis arba el. paštas yra neteisingi.";
            string expectedErrorMessageBodyCapthaError = "login|error_recaptcha";

            Login.CloseCookiesWindow();
            // Login.ClickButtonInfo();
            // Login.ClickMenuButtonPrisijungti();
            Login.EnterEmailAddress(email);
            Login.EnterPassword(invalidPassword);
            Login.ClickButtonPrisijungti();

            Assert.That(Login.GetErrorMessageTitle(), Is.EqualTo(expectedErrorMessageTitle));
            Assert.That(Login.GetErrorMessageBody(), Is.EqualTo(expectedErrorMessageBody)
                                                    .Or.EqualTo(expectedErrorMessageBodyCapthaError));
        }
    }
}

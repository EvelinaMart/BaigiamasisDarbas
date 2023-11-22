using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
    internal class BaseTestCart
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            Login.Open();
            Login.CloseCookiesWindow();
        }

        //[OneTimeTearDown]
        //public void TearDown()
        //{
        //    Driver.QuitDriver();
        //}
    }
}

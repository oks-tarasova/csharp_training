using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AddNewContact : TestBase
    {
        [Test]
        public void TheAddNewContactTest()
        {
            navigator.GoToHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigator.GoToAddNew();
            contactHelper.FillContactForm(new ContactData("Erast", "Fandorin"));
            contactHelper.SubmitContactCreation();
            contactHelper.ReturnToHomePage();
            Logout();
        }
    }
}

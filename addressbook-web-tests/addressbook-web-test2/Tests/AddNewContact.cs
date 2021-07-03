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
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToAddNew();
            app.Contacts.FillContactForm(new ContactData("Erast", "Fandorin"));
            app.Contacts.SubmitContactCreation();
            app.Contacts.ReturnToHomePage();
            Logout();
        }
    }
}

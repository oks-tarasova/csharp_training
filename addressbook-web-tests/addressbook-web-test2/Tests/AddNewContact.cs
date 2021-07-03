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
            ContactData contact = new ContactData("Erast", "Fandorin");
            app.Contacts.Create(contact);
        }
        [Test]
        public void TheAddNewEmptyContactTest()
        {
            ContactData contact = new ContactData("", "");
            app.Contacts.Create(contact);
            app.Navigator.Logout();
        }

    }
}

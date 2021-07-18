using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newContact = new ContactData("Masahiro", "Sibata"); 

            app.Navigator.GoToHomePage();
            if (!app.Contacts.IsAnyContactExist())
            {
                app.Contacts.Create(new ContactData("new", "contact"));
            }

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Modify(0, newContact);

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts[0].Firstname = newContact.Firstname;
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);

        }
    }
}

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
            ContactData oldData = oldContacts[0];

            app.Contacts.Modify(0, newContact);

            Assert.AreEqual(oldContacts.Count, app.Contacts.GetContactCount());

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts[0].Lastname = newContact.Lastname;
            oldContacts[0].Firstname = newContact.Firstname;
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);

            foreach (ContactData contact in newContacts)
            {
                if (contact.Id == oldData.Id)
                {
                    Assert.AreEqual( newContact.Lastname, contact.Lastname);
                    Assert.AreEqual( newContact.Firstname, contact.Firstname);
                }
            }
        }
    }
}

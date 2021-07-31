using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Collections.Generic;


namespace WebAddressbookTests
{
    [TestFixture]

    public class ContactRemovalTests : AuthTestBase
    {

        [Test]
        public void ContactRemovalTest()
        {
            app.Navigator.GoToHomePage();
            if (!app.Contacts.IsAnyContactExist())
            {
                app.Contacts.Create(new ContactData("new", "contact"));
            }

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Remove();

        //    Assert.AreEqual(oldContacts.Count-1, app.Contacts.GetContactCount());

            List<ContactData> newContacts = app.Contacts.GetContactList();

            oldContacts.RemoveAt(0);
            Assert.AreEqual(oldContacts, newContacts);


        }
    }
}

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
            if (app.Contacts.IsAnyContactExist())
            {
                app.Contacts.Modify(1, newContact);
                return;
            }
            app.Contacts.Create(new ContactData("new", "contact"));
            app.Contacts.Modify(1, newContact);

        }
    }
}

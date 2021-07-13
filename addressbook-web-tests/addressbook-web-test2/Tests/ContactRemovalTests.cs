﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]

    public class ContactRemovalTests : AuthTestBase
    {

        [Test]
        public void ContactRemovalTest()
        {
            app.Navigator.GoToHomePage();
            if (app.Contacts.IsAnyContactExist())
            {
                app.Contacts.Remove();
                return;
            }
            app.Contacts.Create(new ContactData("new", "contact"));
            app.Contacts.Remove();
        }
    }
}

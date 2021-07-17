using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;


namespace WebAddressbookTests
{
    [TestFixture]
   public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("modified name");
            newData.Header = "hi";
            newData.Footer = "there";

            app.Navigator.GoToGroupsPage();
            if (!app.Groups.IsAnyGroupExist())
            {
                app.Groups.Create(new GroupData("names"));
            }
            app.Groups.Modify(0, newData);
        }
    }
}

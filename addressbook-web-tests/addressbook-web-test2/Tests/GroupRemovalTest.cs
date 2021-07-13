using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {

        [Test]
        public void GroupRemovalTest()
        {
            app.Navigator.GoToGroupsPage();
            if (app.Groups.IsAnyGroupExist())
            {
                app.Groups.Remove(1);
                return;
            }
            app.Groups.Create(new GroupData("names"));
            app.Groups.Remove(1);
        }
    }
}

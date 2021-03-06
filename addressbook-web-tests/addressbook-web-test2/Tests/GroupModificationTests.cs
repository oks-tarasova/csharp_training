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

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            GroupData oldData = oldGroups[0];

            app.Groups.Modify(0, newData);

            Assert.AreEqual(oldGroups.Count, app.Groups.GetGroupCount());


            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups[0].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);

            foreach (GroupData group in newGroups)
            {
                if (group.Id == oldData.Id)
                {
                    Assert.AreEqual(newData.Name,group.Name);
                }
            }

        }
    }
}

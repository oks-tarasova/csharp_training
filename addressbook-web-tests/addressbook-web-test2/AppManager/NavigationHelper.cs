using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
   public class NavigationHelper : HelperBase
    {
        public NavigationHelper(ApplicationManager manager): base (manager)
        {
        }
        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl("http://localhost/addressbook");
        }

        public void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
        public void GoToAddNew()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }
        public void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
    }
}

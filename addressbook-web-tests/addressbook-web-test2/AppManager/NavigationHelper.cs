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
        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL): base (manager)
        {
            this.baseURL = baseURL;
        }
        public void GoToHomePage()
        {
            if (driver.Url == baseURL + "http://localhost/addressbook")
            {
                return;
            }
                driver.Navigate().GoToUrl("http://localhost/addressbook");
        }

        public void GoToGroupsPage()
        {
            if (driver.Url == baseURL + "/addressbook/group.php" 
                && IsElementPresent(By.Name("new")))
            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }
        public void GoToAddNew()
        { 
            if (driver.Url == baseURL + "/addressbook/edit.php"
                && IsElementPresent(By.Name("submit")))
            {
                return;
            }

            driver.FindElement(By.LinkText("add new")).Click();
        }
        public void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }

        public void GoToDetailsPage(int index)
        {
            if (driver.Url != baseURL + "http://localhost/addressbook")
            {
                driver.Navigate().GoToUrl("http://localhost/addressbook");
            }
            driver.FindElements(By.Name("entry"))[index]
                .FindElements(By.TagName("td"))[6]
                .FindElement(By.TagName("a")).Click();
        }
    }
}

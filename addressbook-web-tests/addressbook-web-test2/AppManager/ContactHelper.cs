using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager) : base(manager)
        {
        }
        public ContactHelper Create(ContactData contact)
        {
            manager.Navigator.GoToAddNew();
            FillContactForm(new ContactData(contact.Firstname, contact.Lastname));
            SubmitContactCreation();
            ReturnToHomePage();
            return this;
        }


        public ContactHelper Modify(int v, ContactData newContact)
        {
            SelectContact();
            InitContactModification();
            FillContactForm(new ContactData(newContact.Firstname, newContact.Lastname));
            SubmitContactModification();
            ReturnToHomePage();
            return this;

        }
        public ContactHelper Remove()
        {
            manager.Navigator.GoToHomePage();
            SelectContact();
            RemoveContact();
            CloseAlertAndGetItsText();
            ReturnToHomePage();
            return this;
        }
        public ContactHelper FillContactForm(ContactData contact)
        {
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("lastname"), contact.Lastname);
            return this;
        }
        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
            contactCache = null;
            return this;

        }
        public ContactHelper ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home")).Click();
            return this;
        }
        public ContactHelper SelectContact()
            {
                driver.FindElement(By.Name("selected[]")).Click();
                return this;
            }

        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            contactCache = null;
            return this;
        }

        public ContactHelper CloseAlertAndGetItsText()
        {
            driver.SwitchTo().Alert().Accept();
            return this;
        }
        public ContactHelper InitContactModification()
        {
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
            return this;
        }
        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();
            contactCache = null;
            return this;
        }
        public bool IsAnyContactExist()
        {
            return IsElementPresent(By.Name("selected[]"));
        }

        private List<ContactData> contactCache = null;

        public List<ContactData> GetContactList()
        {
            if (contactCache == null)
            {
                contactCache = new List<ContactData>();
                manager.Navigator.GoToHomePage();
                ICollection<IWebElement> elements = driver.FindElements(By.Name("selected[]"));
                foreach (IWebElement element in elements)
                {
                    contactCache.Add(new ContactData(element.Text, element.Text));
                }

            }
            return new List<ContactData>(contactCache);
        }


        internal int GetContactCount()
        {
            return driver.FindElements(By.Name("selected[]")).Count;
        }
    }
}

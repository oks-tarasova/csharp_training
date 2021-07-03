﻿using System;
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
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastname);
            return this;
        }
        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
            return this;

        }
        public ContactHelper ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home")).Click();
            return this;
        }
        public ContactHelper SelectContact()
        {
            driver.FindElement(By.XPath("//table[@id='maintable']/tbody/tr[3]/td/input")).Click();
            return this;
        }
        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }

        public ContactHelper CloseAlertAndGetItsText()
        {
            driver.SwitchTo().Alert().Accept();
            return this;
        }
        public ContactHelper InitContactModification()
        {
            driver.FindElement(By.XPath("//table[@id='maintable']/tbody/tr[3]/td[8]/a/img")).Click();
            return this;
        }
        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }
    }
}

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
    public class TestBase
    {
        protected ApplicationManager app;
        protected IWebDriver driver;
        protected HelperBase helper;

        [SetUp]
        public void SetupApplicationManger()
        {
            app = ApplicationManager.GetInstance();

        }
    }
}

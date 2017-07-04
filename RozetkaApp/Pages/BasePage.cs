using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace RozetkaApp
{
    public class BasePage
    {
        protected AppManager manager;
        protected IWebDriver driver;

        public BasePage(AppManager manager)
        {
            this.manager = manager;
            this.driver = manager.Driver;
            PageFactory.InitElements(this.driver, this);
        }
    }
}

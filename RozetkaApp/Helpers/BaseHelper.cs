using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace RozetkaApp
{
    public class BaseHelper
    {
        protected AppManager manager;
        protected IWebDriver driver;

        public BaseHelper(AppManager manager)
        {
            this.manager = manager;
            this.driver = manager.Driver;
        }
    }
}

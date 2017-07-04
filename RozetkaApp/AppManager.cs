using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace RozetkaApp
{
    public class AppManager
    {
        private static AppManager app = null;
        private IWebDriver driver;
        private static string baseUrl;
        private SearchHelper searchHelper;
        private FilteringHelper filteringHelper;
        private NavigationHelper navigationHelper;
        private CatalogPage catalogPage;
        private MainPage mainPage;
        private NavigationPage NavigationPage;
        
        private AppManager ()
        {
            driver = new ChromeDriver(System.IO.Directory.GetCurrentDirectory() + @"\Selenium Rozetka 2\RozetkaApp\ChromeDriver");
            baseUrl = @"http://rozetka.com.ua";
            PageInitialization(this);
        }        

        public static AppManager GetInstance()
        {
            if (app == null)
            {
                app = new AppManager();
                app.driver.Manage().Window.Maximize();
            }
            return app;
        }

        public void GoToBasePage()
        {
            app.driver.Navigate().GoToUrl(baseUrl);
        }

        public IWebDriver Driver
        {
            get { return driver; }
        }

        public Actions ActionWithElement
        {
            get { return new Actions(driver); }
        }

        ~AppManager()
        {
            driver.Quit();
        }

        private void PageInitialization(AppManager manager)
        {
            searchHelper = new SearchHelper(manager);
            filteringHelper = new FilteringHelper(manager);
            navigationHelper = new NavigationHelper(manager);
            catalogPage = new CatalogPage(manager);
            mainPage = new MainPage(manager);
            NavigationPage = new NavigationPage(manager);
        }

        public SearchHelper SearchHelper
        {
            get { return this.searchHelper; }
        }

        public FilteringHelper FilteringHelper
        {
            get { return this.filteringHelper; }
        }

        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        public void WaitForElementById(string id)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement searchedElement = wait.Until<IWebElement>(d => d.FindElement(By.Id(id)));
        }

        public void WaitForElementByXpath(string xpath)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement searchedElement = wait.Until<IWebElement>(d => d.FindElement(By.XPath(xpath)));
        }

        public int ParseTextToInt(IWebElement element)
        {
            int res;
            
            string textIn = element.Text;
            string line = "";
            foreach (char c in textIn)
            {
                if (Int32.TryParse(c.ToString(), out res))
                {
                    line=String.Concat(line, c);
                }
            }
            Int32.TryParse(line, out res);

            return res;
        }
    }
}

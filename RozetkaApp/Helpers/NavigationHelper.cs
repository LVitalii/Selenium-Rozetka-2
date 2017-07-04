using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozetkaApp
{
    public class NavigationHelper : BaseHelper
    {
        public NavigationHelper(AppManager manager) : base(manager)
        { }

        public void GoToSmartphones()
        {
            //IWebElement catalogOfProducts = driver.FindElement(By.CssSelector("span.btn-link-i"));
            //manager.ActionWithElement.MoveToElement(catalogOfProducts).Build().Perform();
            
            IWebElement smarthponeMenu = driver.FindElement(By.XPath("//ul[@id='m-main-ul']/li[2]/a"));
            manager.ActionWithElement.MoveToElement(smarthponeMenu).Build().Perform();
            
            string smarthponeSubMenuXpath = "//ul[@id='m-main-ul']/li[2]//a[contains(@href,'/preset=smartfon/')]";
            manager.WaitForElementByXpath(smarthponeSubMenuXpath);

            IWebElement smarthponeSubMenu = driver.FindElement(By.XPath(smarthponeSubMenuXpath));
            smarthponeSubMenu.Click();
            
            string captionXpath = "//h1[@itemprop='name']";
            manager.WaitForElementByXpath(captionXpath);
        }

        //used for simplify tests for filtering
        public void GoToSmartphonesSimple()
        {
            manager.Driver.Navigate().GoToUrl(@"http://rozetka.com.ua/mobile-phones/c80003/preset=smartfon/");
        }

        //used for simplify tests for filtering
        public void GoToLaptopAsus()
        {
            manager.Driver.Navigate().GoToUrl(@"http://rozetka.com.ua/ua/notebooks/asus/c80004/v004/");
            //manager.WaitForElementByXpath(captionXpath);
        }
        

        //refused from using due to Rozetka shows subsciption pop-up that hovers logo
        public void GoToMainPage()
        {
            IWebElement logo = manager.Driver.FindElement(By.XPath("//div[@class='logo']"));
            logo.Click();
            string promXpath = "//div[@class='main-big-promo']";
            manager.WaitForElementByXpath(promXpath);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace RozetkaApp
{
    public class FilteringHelper : BaseHelper
    {
        public FilteringHelper(AppManager manager) : base(manager)
        { 
        }
        
        public void CheckProducers(string[] producers)
        {                        
            foreach (string producer in producers)
            {
                IWebElement showMoreProducers = manager.Driver.FindElement(By.XPath("//div[@param='producer']//a[@name='show_more_parameters']"));
                showMoreProducers.Click();

                IList<IWebElement> producersItems = manager.Driver.FindElements(By.XPath("//div[@param='producer']//i[@class='filter-parametrs-i-l-i-default-title']"));

                foreach (IWebElement producerItem in producersItems)
                {
                    if (producerItem.Text.Contains(producer))
                    {
                        producerItem.Click();
                        string producerXpath = string.Format("//div[@class='filter-active']//a[contains(.,'{0}')]", producer);

                        manager.WaitForElementByXpath(producerXpath);
                        break;
                    }
                }
            }
        }

        public void SortByPriceDesc()
        {
            ClickOnSortDropDown();
            ClickOnSortByDescPrice();
        }

        public void ClickOnSortByDescPrice()
        {
            IWebElement priceDesc = manager.Driver.FindElement(By.XPath("//li[@id='filter_sortexpensive']/a"));
            priceDesc.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath("//div[@name='drop_menu']")).GetAttribute("style").Contains("visibility: hidden;"));

        }

        public void SortByDiscount()
        {
            ClickOnSortDropDown();
            ClickOnSortByDiscount();            
        }

        public void ClickOnSortByDiscount()
        {
            IWebElement priceDesc = manager.Driver.FindElement(By.XPath("//li[@id='filter_sortaction']/a"));
            priceDesc.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath("//div[@name='drop_menu']")).GetAttribute("style").Contains("visibility: hidden;"));
        }

        public void ClickOnSortDropDown()
        {
            IWebElement sortList = manager.Driver.FindElement(By.CssSelector(".sort-view-link"));
            sortList.Click();
        }

        public bool IsProductsSortedByPriceDesc()
        {
            IList<IWebElement> prices = manager.Driver.FindElements(By.ClassName("g-price-uah"));
            bool isDescending = true;
            int prevPrice = manager.ParseTextToInt(prices[0]); 
            foreach (IWebElement price in prices)
            {
                int currPrice = manager.ParseTextToInt(price);
                isDescending = currPrice <= prevPrice ? isDescending & true : isDescending & false;
                prevPrice = currPrice;
            }
            return isDescending;
        }

        public bool IsWithDiscount()
        { 
            IList<IWebElement> discs = manager.Driver.FindElements(By.XPath(".//i[@name='prices_active_element_original']"));
            return discs.Count > 0;
        }

    }
}

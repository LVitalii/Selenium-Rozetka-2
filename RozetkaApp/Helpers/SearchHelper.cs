using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace RozetkaApp
{
    public class SearchHelper : BaseHelper
    {
        public SearchHelper(AppManager manager) : base (manager)
        { 
        }

        public void SearchByWord(string searchWord)
        {
            IWebElement searchField = driver.FindElement(By.CssSelector("input.rz-header-search-input-text.passive"));
            searchField.SendKeys(searchWord);
            IWebElement searchButton = driver.FindElement(By.CssSelector("button[name='rz-search-button']"));
            searchButton.Click();
            string searchResultId = "search_result_title_text";
            manager.WaitForElementById(searchResultId);
        }

        public bool ResultsContain(string searchWord)
        {
            IList<IWebElement> links = driver.FindElements(By.CssSelector(".g-i-tile-i-title a"));
            bool contains = false;
            foreach (IWebElement link in links)
            {
                if (link.Text.Contains(searchWord))
                    contains = true;
            }
            return contains;
        }

        public bool Show32ProductExists()
        {
            IWebElement more32Product = driver.FindElement(By.CssSelector(".g-i-more-link-text"));
            return more32Product.Displayed;
        }
    }
}

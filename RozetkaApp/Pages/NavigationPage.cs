using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace RozetkaApp
{
    public class NavigationPage : BasePage
    {
        public NavigationPage (AppManager manager) : base (manager)
        { }

        [FindsBy(How = How.XPath, Using = "//div[@class='logo']")]
        public HtmlLink lnkMain;

        [FindsBy(How = How.CssSelector, Using = "input.rz-header-search-input-text.passive")]
        public IWebElement txtSearch;

        [FindsBy(How = How.CssSelector, Using = "button[name='rz-search-button']")]
        public IWebElement btnSearch;

        [FindsBy(How = How.CssSelector, Using = ".m-top>li:first-child")]
        public HtmlLink lnkMenuQuestions;

        [FindsBy(How = How.CssSelector, Using = ".m-top>li:nth-child(2)")]
        public HtmlLink lnkCredit;

        [FindsBy(How = How.XPath, Using = ".m-top>li:nth-child(3)")]
        public HtmlLink lnkDelivery;

        [FindsBy(How = How.XPath, Using = ".m-top>li:nth-child(4)")]
        public HtmlLink lnkWarranty;

        [FindsBy(How = How.XPath, Using = ".m-top>li:nth-child(5)")]
        public HtmlLink lnkContacts;

        [FindsBy(How = How.XPath, Using = ".m-top>li:nth-child(6)")]
        public HtmlLink lnkTrack;

        [FindsBy(How = How.XPath, Using = ".m-top>li:last-child")]
        public HtmlLink lnkSell;
    }
}

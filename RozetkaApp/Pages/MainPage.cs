using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace RozetkaApp
{
    public class MainPage : BasePage
    {
        public MainPage(AppManager manager) : base(manager)
        { }

        [FindsBy(How = How.CssSelector, Using = ".m-tabs li:first-child")]
        public HtmlLink lnkTop;

        [FindsBy(How = How.CssSelector, Using = ".m-tabs li:nth-child(2)")]
        public HtmlLink lnkPresents;

        [FindsBy(How = How.CssSelector, Using = ".m-tabs li:nth-child(3)")]
        public HtmlLink lnkDiscounts;

        [FindsBy(How = How.CssSelector, Using = ".m-tabs li:last-child")]
        public HtmlLink lnkPrices;       

    }
}

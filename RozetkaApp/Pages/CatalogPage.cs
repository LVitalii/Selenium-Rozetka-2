using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
//using OpenQA.Selenium.Interactions;

namespace RozetkaApp
{
    public class CatalogPage : BasePage
    {
        public CatalogPage(AppManager manager) : base(manager) { }

        [FindsBy(How = How.Id, Using = "2416")]
        public HtmlLink lnkLaptops;

        [FindsBy(How = How.Id, Using = "3361")]
        public HtmlLink lnkSmartphones;

        [FindsBy(How = How.Id, Using = "4306")]
        public HtmlLink lnkAppliances;

        [FindsBy(How = How.Id, Using = "5300")]
        public HtmlLink lnkHouseGoods;

        [FindsBy(How = How.Id, Using = "6700")]
        public HtmlLink lnkPlumbing;

    }
}

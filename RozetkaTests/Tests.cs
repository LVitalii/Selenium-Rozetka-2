using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RozetkaApp;

namespace RozetkaTests
{
    [TestClass]
    public class Tests
    {
        protected AppManager app;

        [TestInitialize]
        public void SetUp()
        {
            app = AppManager.GetInstance();
            app.GoToBasePage();
        }

        [TestMethod]
        public void MainSearch()
        {
            string searchWord = "Hyundai";
            app.SearchHelper.SearchByWord(searchWord);
            Assert.IsTrue(app.SearchHelper.ResultsContain(searchWord));
            Assert.IsTrue(app.SearchHelper.Show32ProductExists());
        }

        [TestMethod]
        public void FilterInSmartphones()
        {
            app.NavigationHelper.GoToSmartphones();
            string[] producers = { "Apple", "Samsung" };
            app.FilteringHelper.CheckProducers(producers);
            app.FilteringHelper.SortByPriceDesc();
            Assert.IsTrue(app.FilteringHelper.IsProductsSortedByPriceDesc());
        }
    }
}

using System;
using TechTalk.SpecFlow;
using RozetkaApp;
using NUnit.Framework;

namespace SpecFlowRozetka
{
    [Binding]
    public class FilterSmartphonesSteps
    {
        protected AppManager app;

        [BeforeStep]
        public void OpenRozetkaPage()
        {
            app = AppManager.GetInstance();
            //app.GoToBasePage();
        }       

        [Given(@"I have opened Smartphone main page")]
        public void GivenIHaveOpenedSmartphonePage()
        {
            app.NavigationHelper.GoToSmartphonesSimple();
        }

        
        [When(@"I press sort by descending price")]
        public void WhenIPressSortByDescendingPrice()
        {
            app.FilteringHelper.SortByPriceDesc();
        }
        
        [Then(@"The cheapest smartphones are shown first")]
        public void ThenTheCheapestSmartphonesAreShownFirst()
        {
            Assert.That(app.FilteringHelper.IsProductsSortedByPriceDesc(), Is.True);
        }

        [When(@"I click on Sort drop-down list")]
        public void WhenIClickOnSortDrop_DownList()
        {
            app.FilteringHelper.ClickOnSortDropDown();
        }

        [When(@"Click on Discount item")]
        public void WhenClickOnDiscountItem()
        {
            app.FilteringHelper.ClickOnSortByDiscount();
        }

        [Then(@"The smartphones with discounts are shown")]
        public void ThenTheSmartphonesWithDiscountsAreShown()
        {
            Assert.That(app.FilteringHelper.IsWithDiscount(), Is.True);
        }

    }
}

using System;
using TechTalk.SpecFlow;
using RozetkaApp;
using NUnit.Framework;

namespace SpecFlowRozetka
{
    [Binding]
    public class SearchForSmartphoneSteps
    {
        protected AppManager app;

        [Given(@"I have opened Rozetka page")]
        public void GivenIHaveOpenedRozetkaPage()
        {
            app = AppManager.GetInstance();
            app.GoToBasePage();
        }

        [When(@"Type (.*) name to searchbox")]
        public void WhenTypeSamsungSNameToSearchbox(string name)
        {
            app.SearchHelper.TypeWordToSearchBox(name);
        }

        
        [When(@"Click on Search")]
        public void WhenClickOnSearch()
        {
            app.SearchHelper.ClickOnSearchButton();
        }
        
        [Then(@"all the searches contain (.*) name")]
        public void ThenAllTheSearchesContainSamsungSName(string name)
        {
            Assert.IsTrue(app.SearchHelper.ResultsContain(name));
        }
    }
}

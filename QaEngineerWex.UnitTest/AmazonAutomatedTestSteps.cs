using TechTalk.SpecFlow;
using SpecFlow.Challenge.Model;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlow.Challenge.UnitTest
{
    [Binding]
    public class AmazonAutomatedTestSteps
    {
        private readonly AmazonSearch _amazonSearch;
        private readonly AmazonSelectedObject _amazonSelectedObject;
        private AmazonObjectItem SelectedObjectItem { get; set; }

        public AmazonAutomatedTestSteps()
        {
            #region ' Fake AMAZON site data '
            List<AmazonObjectItem> list = new List<AmazonObjectItem>();
            list.Add(new AmazonObjectItem()
            {
                ID = 1,
                Name = "Pair of paints.",
                ObjectType = AmazonObjectType.BoysFashion,
                Price = 50.00
            });
            list.Add(new AmazonObjectItem()
            {
                ID = 2,
                Name = "DELL Ultrabook",
                ObjectType = AmazonObjectType.Computers,
                Price = 1500.00
            });
            list.Add(new AmazonObjectItem()
            {
                ID = 3,
                Name = "Love Story",
                ObjectType = AmazonObjectType.Books,
                Price = 10.00
            });
            list.Add(new AmazonObjectItem()
            {
                ID = 4,
                Name = "Algortims and programming logic",
                ObjectType = AmazonObjectType.Books,
                Price = 25.00
            });
            list.Add(new AmazonObjectItem()
            {
                ID = 4,
                Name = "Test automation design - from paper to software.",
                ObjectType = AmazonObjectType.Books,
                Price = 173.00
            });
            list.Add(new AmazonObjectItem()
            {
                ID = 4,
                Name = "Techniques of Test automation - Design, build and refatctoring.",
                ObjectType = AmazonObjectType.Books,
                Price = 189.00
            });
            list.Add(new AmazonObjectItem()
            {
                ID = 4,
                Name = "BDD Test automation - Build bridge bettween stackholder and developer.",
                ObjectType = AmazonObjectType.Books,
                Price = 98.00
            });
            list.Add(new AmazonObjectItem()
            {
                ID = 4,
                Name = "TDD Test automation: skeptical but pratical approach.",
                ObjectType = AmazonObjectType.Books,
                Price = 99.00
            });

            #endregion

            this._amazonSearch = new AmazonSearch()
            {
                SearchCriteriaFilter = AmazonObjectType.Books,
                SearchFor = "Test automation",
                Url = "www.amazon.com"
            };

            this._amazonSelectedObject = new AmazonSelectedObject(this._amazonSearch, list);
        }

        [Given(@"I navigate to ""(.*)""\.")]
        public void GivenINavigateTo_(string Url)
        {
            this._amazonSearch.Url = Url;
        }

        [Given(@"I select the option ""(.*)"" in the dropdown next to the search text input criteria\.")]
        public void GivenISelectTheOptionInTheDropdownNextToTheSearchTextInputCriteria_(AmazonObjectType criteria)
        {
            this._amazonSearch.SearchCriteriaFilter = criteria;
        }

        [When(@"I reach the detailed book page, I check if the name in the header is the same name of the book that I select previously\.")]
        public void WhenIReachTheDetailedBookPageICheckIfTheNameInTheHeaderIsTheSameNameOfTheBookThatISelectPreviously_()
        {
            Assert.IsTrue(this.SelectedObjectItem.ValidationChecker());
        }
        
        [Then(@"I search for ""(.*)""\.")]
        public void ThenISearchFor_(string searchFor)
        {
            this._amazonSearch.SearchFor = searchFor;
        }
        
        [Then(@"I select the cheapest book of the page without using any sorting method available\.")]
        public void ThenISelectTheCheapestBookOfThePageWithoutUsingAnySortingMethodAvailable_()
        {
            this.SelectedObjectItem = this._amazonSelectedObject.GetWithCriteriaAndMinCriteria();
        }
    }
}

using System.Linq;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using SpecFlow.Challenge.Model.WEX;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlow.Challenge.UnitTest
{
    [Binding]
    public class WexIncAutomatedTestSteps
    {
        private readonly WexSearch _wexSearch;
        private readonly WexSelectedObject _wexSelectedObject;
        private WexObjectItem SelectedObjectItem { get; set; }
        private List<WexObjectItem> PlansOnAllWexCriteriaList { get; set; }
        public WexIncAutomatedTestSteps()
        {
            #region ' Fake AMAZON site data '
            this.PlansOnAllWexCriteriaList = new List<WexObjectItem>();
            this.PlansOnAllWexCriteriaList.Add(new WexObjectItem()
            {
                ID = 1,
                Headline = "Why High Deductible Health Plans Are Trending at Colleges and Universities",
                ObjectType = WexObjectType.Health,
                NewsBody = @"For the past five years, Sibson Consulting has released its annual College and University Benefits Study (CUBS), which analyzes benefit programs data from hundreds of higher education institutions to determine what colleges and universities are doing to attract and retain top talent. Its most recent report examined the plans of more than 450 public and private colleges and found that the percentage of institutions that offer high deductible health plans (HDHPs) to their faculty and staff has grown explosively over two years, as has the percent that HDHPs represent of all plans offered by colleges. In 2017, nearly 72 percent of higher-ed healthcare plans offered HDHPs as opposed to 59 percent of plans that offered them in 2015. In the meantime, the percentage of preferred provider organization (PPO) and point-of-service (POS) plans with deductibles less than $1,000 have declined (from 46 percent in 2015 to 39 percent in 2017), while HMO plans saw only a nominal increase. Colleges are also far more likely to offer their employees health savings accounts (HSAs) than they are to offer health reimbursement arrangements (HRAs), or HDHPs without either account. Sixty-two percent of HDHPs offered have HSAs, while 15 percent have HRAs. CUBS reports that higher education medical plans have historically been more valuable to employees than what they might be offered by a corporate employer, but that this has become less true in recent years as health insurance costs have risen. HDHPs have been a way for universities to proactively address rising healthcare costs. This embrace of HDHPs and HSAs reflects a national trend across industries. According to data from the National Health Interview Survey, from 2007 through 2017, enrollment in HDHPs with an HSA (4.2 percent to 18.9 percent) and without an HSA (10.6 percent to 24.5 percent) increased among adults aged 18–64 with employment-based coverage, while enrollment in traditional plans decreased. That study also found that enrollment in HDHPs with an HSA is more prevalent among those with higher levels of family income and educational attainment. Other key benefits trends that were explored in the CUBS report include access to an on-site fitness centers—which was the most common wellness initiative, offered by 87 percent of colleges. On-site biometric screenings and obesity-control and weight-loss programs have also become commonplace, and were offered to employees by nearly two thirds of colleges in 2017. And prescription drug cost-management programs have expanded dramatically, across mandatory mail-order drug programs, mandatory generics programs and step therapy. Learn more about the value of HDHPs and HSAs."
            });
            this.PlansOnAllWexCriteriaList.Add(new WexObjectItem()
            {
                ID = 2,
                Headline = "6 Best Practices for Engaging Employers and Members with CDHP Plans",
                ObjectType = WexObjectType.Health,
                NewsBody = @"I recently worked with Jeff Bakke, WEX Health’s chief strategy officer, to cohost an America’s Health Insurance Plans (AHIP) webinar on consumer-directed healthcare plans (CDHPs) and how they can be used to improve employer partnership and member engagement. In addition to sharing the full webinar with WEX Health Partners, I’m highlighting some of the best practices that Jeff and I have come across in our work at our respective companies. As uncertain out-of-pocket expenses and rising deductibles combine to put financial strain on more Americans, Jeff and I have both become passionate about the role that CDHPs can play in reducing financial stress and empowering employees to successfully manage their healthcare expenses. But first the challenge is to educate both employers and employees about the plans and to engage them with the accounts before and after open enrollment. Here are six of the chief learnings that Jeff and I shared in our webinar about maximizing engagement with CDHPs: Get involved as early as possible with a new employer. Getting on the same page with an employer is a must. If possible, review their existing plan documentation early on, and gain an understanding of their employee populations and how to best reach them. Not only will this inform your recommendations going forward, but it will allow you to inject account-based plans into the conversation from the beginning. Don’t overwhelm employees with information during open enrollment. Instead, give them the personalized experiences and communications they need when they need it. People can consume only what’s relatable to them in the present. Consider how you can deliver individual employee guided tours, and when certain tips and resources will be best received. Maintain personal touches with employees post-enrollment. Look for ways to continue to create in-person touchpoints with employees, whether with an outreach call after they experience their first medical claim with an HRA account or by hosting a brown-bag session where employees can have their individual questions about their CDHP answered. When person-to-person isn’t feasible, email is the next best way to communicate. Some employees prefer paper, depending on industry and demographics, but overall, email is the preferred method for employees to receive information about their CDHP accounts. We’ve also learned that, for quick updates, people prefer text messages or automated notifications—e.g., “Your HSA available cash balance is below $250.00.” Help employees track and measure their healthcare goals online. Beyond just working with employees to establish an HSA or HRA savings goal at open enrollment, it’s important to provide tools for employees to be able to measure and track their progress toward that goal and to make changes as needed. Give employees ongoing access to online tools and resources. Employees need to be able to have their account information at their fingertips when they want it. Dashboard views can give employees a consolidated snapshot of their experience and how their plan is working. People generally don’t spend a lot of time making decisions about their healthcare benefits, but if we can give them the data in an easy-to-use, accessible way, they’re more inclined to make better decisions as they move forward with their plans."
            });
            this.PlansOnAllWexCriteriaList.Add(new WexObjectItem()
            {
                ID = 3,
                Headline = "WEX Reports Strong Earnings Growth, Plans to Hire 175 Workers in Maine",
                ObjectType = WexObjectType.WEXCorporate,
                NewsBody = @"Corporate payment services provider Wex Inc. of South Portland reported strong earnings growth for the second quarter, aided in part by higher fuel prices and lower corporate taxes. The company also said it plans to hire an additional 175 employees in Maine by the end of this year as a result of new contracts with fuel producers Shell Oil Co. and Chevron Corp. https://www.pressherald.com/2018/08/02/wex-reports-strong-earnings-plans-to-hire-175-in-maine/"
            });

            //**************************************************//
            List<WexObjectItem> corpotatePlansOnAllWexCriteriaList = new List<WexObjectItem>();
            corpotatePlansOnAllWexCriteriaList.Add(new WexObjectItem()
            {
                ID = 1,
                Headline = "WEX Reports Strong Earnings Growth, Plans to Hire 175 Workers in Maine",
                ObjectType = WexObjectType.WEXCorporate,
                NewsBody = @"Corporate payment services provider Wex Inc. of South Portland reported strong earnings growth for the second quarter, aided in part by higher fuel prices and lower corporate taxes. The company also said it plans to hire an additional 175 employees in Maine by the end of this year as a result of new contracts with fuel producers Shell Oil Co. and Chevron Corp. https://www.pressherald.com/2018/08/02/wex-reports-strong-earnings-plans-to-hire-175-in-maine/"
            });
            corpotatePlansOnAllWexCriteriaList.Add(new WexObjectItem()
            {
                ID = 2,
                Headline = "Why High Deductible Health Plans Are Trending at Colleges and Universities",
                ObjectType = WexObjectType.Health,
                NewsBody = @"For the past five years, Sibson Consulting has released its annual College and University Benefits Study (CUBS), which analyzes benefit programs data from hundreds of higher education institutions to determine what colleges and universities are doing to attract and retain top talent. Its most recent report examined the plans of more than 450 public and private colleges and found that the percentage of institutions that offer high deductible health plans (HDHPs) to their faculty and staff has grown explosively over two years, as has the percent that HDHPs represent of all plans offered by colleges. In 2017, nearly 72 percent of higher-ed healthcare plans offered HDHPs as opposed to 59 percent of plans that offered them in 2015. In the meantime, the percentage of preferred provider organization (PPO) and point-of-service (POS) plans with deductibles less than $1,000 have declined (from 46 percent in 2015 to 39 percent in 2017), while HMO plans saw only a nominal increase. Colleges are also far more likely to offer their employees health savings accounts (HSAs) than they are to offer health reimbursement arrangements (HRAs), or HDHPs without either account. Sixty-two percent of HDHPs offered have HSAs, while 15 percent have HRAs. CUBS reports that higher education medical plans have historically been more valuable to employees than what they might be offered by a corporate employer, but that this has become less true in recent years as health insurance costs have risen. HDHPs have been a way for universities to proactively address rising healthcare costs. This embrace of HDHPs and HSAs reflects a national trend across industries. According to data from the National Health Interview Survey, from 2007 through 2017, enrollment in HDHPs with an HSA (4.2 percent to 18.9 percent) and without an HSA (10.6 percent to 24.5 percent) increased among adults aged 18–64 with employment-based coverage, while enrollment in traditional plans decreased. That study also found that enrollment in HDHPs with an HSA is more prevalent among those with higher levels of family income and educational attainment. Other key benefits trends that were explored in the CUBS report include access to an on-site fitness centers—which was the most common wellness initiative, offered by 87 percent of colleges. On-site biometric screenings and obesity-control and weight-loss programs have also become commonplace, and were offered to employees by nearly two thirds of colleges in 2017. And prescription drug cost-management programs have expanded dramatically, across mandatory mail-order drug programs, mandatory generics programs and step therapy. Learn more about the value of HDHPs and HSAs."
            });
            corpotatePlansOnAllWexCriteriaList.Add(new WexObjectItem()
            {
                ID = 3,
                Headline = "6 Best Practices for Engaging Employers and Members with CDHP Plans",
                ObjectType = WexObjectType.Health,
                NewsBody = @"I recently worked with Jeff Bakke, WEX Health’s chief strategy officer, to cohost an America’s Health Insurance Plans (AHIP) webinar on consumer-directed healthcare plans (CDHPs) and how they can be used to improve employer partnership and member engagement. In addition to sharing the full webinar with WEX Health Partners, I’m highlighting some of the best practices that Jeff and I have come across in our work at our respective companies. As uncertain out-of-pocket expenses and rising deductibles combine to put financial strain on more Americans, Jeff and I have both become passionate about the role that CDHPs can play in reducing financial stress and empowering employees to successfully manage their healthcare expenses. But first the challenge is to educate both employers and employees about the plans and to engage them with the accounts before and after open enrollment. Here are six of the chief learnings that Jeff and I shared in our webinar about maximizing engagement with CDHPs: Get involved as early as possible with a new employer. Getting on the same page with an employer is a must. If possible, review their existing plan documentation early on, and gain an understanding of their employee populations and how to best reach them. Not only will this inform your recommendations going forward, but it will allow you to inject account-based plans into the conversation from the beginning. Don’t overwhelm employees with information during open enrollment. Instead, give them the personalized experiences and communications they need when they need it. People can consume only what’s relatable to them in the present. Consider how you can deliver individual employee guided tours, and when certain tips and resources will be best received. Maintain personal touches with employees post-enrollment. Look for ways to continue to create in-person touchpoints with employees, whether with an outreach call after they experience their first medical claim with an HRA account or by hosting a brown-bag session where employees can have their individual questions about their CDHP answered. When person-to-person isn’t feasible, email is the next best way to communicate. Some employees prefer paper, depending on industry and demographics, but overall, email is the preferred method for employees to receive information about their CDHP accounts. We’ve also learned that, for quick updates, people prefer text messages or automated notifications—e.g., “Your HSA available cash balance is below $250.00.” Help employees track and measure their healthcare goals online. Beyond just working with employees to establish an HSA or HRA savings goal at open enrollment, it’s important to provide tools for employees to be able to measure and track their progress toward that goal and to make changes as needed. Give employees ongoing access to online tools and resources. Employees need to be able to have their account information at their fingertips when they want it. Dashboard views can give employees a consolidated snapshot of their experience and how their plan is working. People generally don’t spend a lot of time making decisions about their healthcare benefits, but if we can give them the data in an easy-to-use, accessible way, they’re more inclined to make better decisions as they move forward with their plans."
            });
            #endregion

            this._wexSearch = new WexSearch()
            {
                SearchCriteriaFilter = WexObjectType.AllWEX,
                SearchFor = "corporative plans",
                Url = "www.wexinc.com"
            };

            this._wexSelectedObject = new WexSelectedObject(this._wexSearch, corpotatePlansOnAllWexCriteriaList);
        }

        [Given(@"I navigate on ""(.*)""\.")]
        public void GivenINavigateOn_(string url)
        {
            this._wexSearch.Url = url;
        }
        
        [Given(@"I select the option ""(.*)"" in the dropdown next to the search text input\.")]
        public void GivenISelectTheOptionInTheDropdownNextToTheSearchTextInput_(WexObjectType criteria)
        {
            this._wexSearch.SearchCriteriaFilter = criteria;
        }
        
        [When(@"I get the item, I check if this item is contained at ""(.*)"", searched by ""(.*)""\.")]
        public void WhenIGetTheItemICheckIfThisItemIsContainedAtSearchedBy_(WexObjectType criteria, string searchFor)
        {
            bool tst = this.PlansOnAllWexCriteriaList.Where(
                    w => ((criteria & w.ObjectType) == w.ObjectType) && (w.NewsBody.Contains(searchFor) || w.Headline.Contains(searchFor))
                ).Contains(this.SelectedObjectItem, new WexObjectItemEqualityComparer());
            Assert.IsTrue(tst);
        }
        
        [Then(@"I search by ""(.*)""\.")]
        public void ThenISearchBy_(string searchFor)
        {
            this._wexSearch.SearchFor = searchFor;
        }
        
        [Then(@"I select any item of search result\.")]
        public void ThenISelectAnyItemOfSearchResult_()
        {
            this.SelectedObjectItem = this._wexSelectedObject.GetWithCriteriaAndMinCriteria();
        }
    }
}

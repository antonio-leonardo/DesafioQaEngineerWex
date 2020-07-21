using SpecFlow.Challenge.Model.Abstractions;

namespace SpecFlow.Challenge.Model.WEX
{
    public class WexSearch : IEcommerceSearch<WexObjectType>
    {
        public string Url { get; set; }
        public string SearchFor { get; set; }
        public WexObjectType SearchCriteriaFilter { get; set; }
    }
}
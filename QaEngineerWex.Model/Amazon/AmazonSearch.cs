using QaEngineerWex.Model.Service;

namespace QaEngineerWex.Model
{
    public class AmazonSearch : IEcommerceSearch<AmazonObjectType>
    {
        public string Url { get; set; }
        public string SearchFor { get; set; }
        public AmazonObjectType SearchCriteriaFilter { get; set; }
    }
}
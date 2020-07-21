using System.Linq;
using System.Collections.Generic;

using SpecFlow.Challenge.Model.Abstractions;

namespace SpecFlow.Challenge.Model
{
    public class AmazonSelectedObject : ABEcommerceSelectedObject<AmazonObjectItem, AmazonObjectType>
    {
        public AmazonSelectedObject(AmazonSearch ecommerceSearch, List<AmazonObjectItem> list) : base(ecommerceSearch, list)
        {
        }

        public AmazonSelectedObject(AmazonSearch ecommerceSearch, params AmazonObjectItem[] list) : base(ecommerceSearch, list)
        {
        }

        public override IEnumerable<AmazonObjectItem> GetObjectsByCriteria()
        {
            return this._list.Where(x => x.ObjectType == this._ecommerceSearch.SearchCriteriaFilter).ToList();
        }

        public override IEnumerable<AmazonObjectItem> GetObjectsByCriteriaAndFilter(string filter)
        {
            return this._list.Where(x => x.ObjectType == this._ecommerceSearch.SearchCriteriaFilter && (this._ecommerceSearch.SearchFor.ToLower().Contains(filter.ToLower()))).ToList();
        }

        public override AmazonObjectItem GetWithCriteriaAndMinCriteria()
        {
            double minPrice = this._list.Min(x => x.Price);
            return this._list.Where(x => x.ObjectType == this._ecommerceSearch.SearchCriteriaFilter && x.Price == minPrice).FirstOrDefault();
        }

        public override AmazonObjectItem GetWithCriteriaAndMaxCriteria()
        {
            double maxPrice = this._list.Max(x => x.Price);
            return this._list.Where(x => x.ObjectType == this._ecommerceSearch.SearchCriteriaFilter && x.Price == maxPrice).FirstOrDefault();
        }
    }
}
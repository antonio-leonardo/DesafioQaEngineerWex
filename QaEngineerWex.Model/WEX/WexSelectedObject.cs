using System.Linq;
using System.Collections.Generic;

using SpecFlow.Challenge.Model.Abstractions;

namespace SpecFlow.Challenge.Model.WEX
{
    public class WexSelectedObject : ABEcommerceSelectedObject<WexObjectItem, WexObjectType>
    {
        public WexSelectedObject(WexSearch ecommerceSearch, List<WexObjectItem> list) : base(ecommerceSearch, list)
        {
        }

        public WexSelectedObject(WexSearch ecommerceSearch, params WexObjectItem[] list) : base(ecommerceSearch, list)
        {
        }

        public override IEnumerable<WexObjectItem> GetObjectsByCriteria()
        {
            return this._list.Where(x => x.ObjectType == this._ecommerceSearch.SearchCriteriaFilter).ToList();
        }

        public override IEnumerable<WexObjectItem> GetObjectsByCriteriaAndFilter(string filter)
        {
            return this._list.Where(x => x.ObjectType == this._ecommerceSearch.SearchCriteriaFilter && (this._ecommerceSearch.SearchFor.ToLower().Contains(filter.ToLower()))).ToList();
        }

        public override WexObjectItem GetWithCriteriaAndMinCriteria()
        {
            long minCriteria = this._list.Min(x => x.ID);
            return this._list.Where(x => x.ID == minCriteria).FirstOrDefault();
        }

        public override WexObjectItem GetWithCriteriaAndMaxCriteria()
        {
            long maxCriteria = this._list.Max(x => x.ID);
            return this._list.Where(x => x.ID == maxCriteria).FirstOrDefault();
        }
    }
}

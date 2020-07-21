using System.Collections.Generic;

using SpecFlow.Challenge.Model.Abstractions;

namespace SpecFlow.Challenge.Model.WEX
{
    public class WexObjectItem : IObjectItem<WexObjectType>
    {
        private readonly IEnumerable<WexObjectItem> _itemsToCompare;
        public WexObjectItem()
        {
        }

        public WexObjectItem(List<WexObjectItem> itemsToCompare)
        {
            this._itemsToCompare = itemsToCompare;
        }

        public WexObjectItem(params WexObjectItem[] itemsToCompare)
        {
            this._itemsToCompare = itemsToCompare;
        }

        public long ID { get; set; }
        public string Headline { get; set; }

        public string NewsBody { get; set; }
        public WexObjectType ObjectType { get; set; }

        public bool ValidationChecker()
        {
            bool result = false;
            foreach (WexObjectItem item in this._itemsToCompare)
            {
                if (item.NewsBody == this.NewsBody && item.Headline == this.Headline)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }

    public class WexObjectItemEqualityComparer : IEqualityComparer<WexObjectItem>
    {
        public bool Equals(WexObjectItem x, WexObjectItem y)
        {
            return (x.Headline == y.Headline && x.NewsBody == y.NewsBody);
        }

        public int GetHashCode(WexObjectItem obj)
        {
            string hCode = obj.Headline + obj.NewsBody;
            return hCode.GetHashCode();
        }
    }
}

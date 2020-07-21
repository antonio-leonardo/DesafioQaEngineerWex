using System;
using System.Linq;
using System.Collections.Generic;

namespace SpecFlow.Challenge.Model.Abstractions
{
    /// <summary>
    /// E-Commerce abstraction that contains the core definitions of searchs
    /// </summary>
    /// <typeparam name="ObjectItem">Generic parameter with object item type from Interface definition</typeparam>
    /// <typeparam name="TEnum">This generic parameter represents the finit values criteria of search</typeparam>
    public abstract class ABEcommerceSelectedObject<ObjectItem, TEnum>
        where ObjectItem : IObjectItem<TEnum>
        where TEnum : struct, IConvertible
    {
        /// <summary>
        /// Navigation property to abstraction setted by Dependency Injection
        /// </summary>
        protected readonly IEcommerceSearch<TEnum> _ecommerceSearch;

        protected readonly IEnumerable<ObjectItem> _list;

        /// <summary>
        /// Constructor that receives dependecy-injection from IEcommerceSearch abstraction definition
        /// </summary>
        /// <param name="ecommerceSearch"></param>
        public ABEcommerceSelectedObject(IEcommerceSearch<TEnum> ecommerceSearch, List<ObjectItem> list)
        {
            this._list = list;
            this._ecommerceSearch = ecommerceSearch;
        }

        /// <summary>
        /// Constructor that receives dependecy-injection from IEcommerceSearch abstraction definition
        /// </summary>
        /// <param name="ecommerceSearch"></param>
        public ABEcommerceSelectedObject(IEcommerceSearch<TEnum> ecommerceSearch, params ObjectItem[] list) : this(ecommerceSearch, list.ToList())
        {
        }

        /// <summary>
        /// Returning collection by Criteria at "_ecommerceSearch" object
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerable<ObjectItem> GetObjectsByCriteria();

        /// <summary>
        /// Returning collection by Criteria at "_ecommerceSearch" object
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public abstract IEnumerable<ObjectItem> GetObjectsByCriteriaAndFilter(string filter);

        /// <summary>
        /// Get the item with low cost
        /// </summary>
        /// <returns></returns>
        public abstract ObjectItem GetWithCriteriaAndMinCriteria();

        /// <summary>
        /// Get the item with as more expensive
        /// </summary>
        /// <returns></returns>
        public abstract ObjectItem GetWithCriteriaAndMaxCriteria();
    }
}
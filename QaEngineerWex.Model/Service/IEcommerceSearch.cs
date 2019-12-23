using System;

namespace QaEngineerWex.Model.Service
{
    /// <summary>
    /// Interface that represents the E-Commerce Search concept
    /// </summary>
    /// <typeparam name="TEnum">This generic parameter represents the finit values criteria of search</typeparam>
    public interface IEcommerceSearch<TEnum> where TEnum : struct, IConvertible
    {
        /// <summary>
        /// E-Commerce Site URL
        /// </summary>
        string Url { get; set; }

        /// <summary>
        /// The query-string object search for
        /// </summary>
        string SearchFor { get; set; }

        /// <summary>
        /// Finite items criteria filter
        /// </summary>
        TEnum SearchCriteriaFilter { get; set; }
    }
}
using System;

namespace SpecFlow.Challenge.Model.Abstractions
{
    /// <summary>
    /// Interface tha contains the E-Commerce object-item definition
    /// </summary>
    /// <typeparam name="TEnum"></typeparam>
    public interface IObjectItem<TEnum> where TEnum : struct, IConvertible
    {
        long ID { get; set; }
        TEnum ObjectType { get; set; }
        bool ValidationChecker();
    }
}

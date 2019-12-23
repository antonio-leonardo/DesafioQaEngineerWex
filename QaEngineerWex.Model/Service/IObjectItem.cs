using System;

namespace QaEngineerWex.Model.Service
{
    /// <summary>
    /// Interface tha contains the E-Commerce object-item definition
    /// </summary>
    /// <typeparam name="TEnum"></typeparam>
    public interface IObjectItem<TEnum> where TEnum : struct, IConvertible
    {
        long ID { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        TEnum ObjectType { get; set; }
        bool ValidationChecker();
    }
}

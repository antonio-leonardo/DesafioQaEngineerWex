using System;

namespace QaEngineerWex.Model.WEX
{
    [Flags]
    public enum WexObjectType
    {
        None = 0,
        CorporatePayments,
        Fleet,
        Health,
        WEXCorporate,
        WEXHelth,
        AllWEX = CorporatePayments | Fleet | Health | WEXCorporate | WEXHelth
    }
}

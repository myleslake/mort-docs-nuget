using System.Runtime.Serialization;

namespace EquifaxUDM.Models.MortDocs.Enums
{
    public enum ReviewState
    {
        [EnumMember(Value = "Accepted")]
        Accepted = 1,
        [EnumMember(Value = "Deferred")]
        Deferred = 2,
        [EnumMember(Value = "Rejected")]
        Rejected = 3,
        [EnumMember(Value = "Discarded")]
        Discarded = 4
    }
}

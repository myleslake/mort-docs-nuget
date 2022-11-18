using System.Runtime.Serialization;

namespace EquifaxUDM.Models.MortDocs.Enums
{
    public enum DocumentState
    {
        [EnumMember(Value = "Pending")]
        Pending = 1,
        [EnumMember(Value = "Completed")]
        Completed = 2,
        [EnumMember(Value = "Archived")]
        Archived = 3
    }
}
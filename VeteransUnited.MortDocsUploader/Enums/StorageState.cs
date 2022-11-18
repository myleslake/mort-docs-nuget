using System.Runtime.Serialization;

namespace EquifaxUDM.Models.MortDocs.Enums
{
    public enum StorageState
    {
        [EnumMember(Value = "Pending")]
        PendingEnum = 1,
        [EnumMember(Value = "Stored")]
        StoredEnum = 2,
        [EnumMember(Value = "Failed")]
        FailedEnum = 3,
        [EnumMember(Value = "Inactive")]
        InactiveEnum = 4,
        [EnumMember(Value = "Removed")]
        RemovedEnum = 5
    }
}
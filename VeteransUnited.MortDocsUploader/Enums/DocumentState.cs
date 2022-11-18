using System.Runtime.Serialization;

namespace VeteransUnited.MortDocsUploader.Enums
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
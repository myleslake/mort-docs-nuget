using System;
using System.Runtime.Serialization;

namespace VeteransUnited.MortDocsUploader.Models
{
    public class OriginalDoc
    {
        [DataMember(Name = "documentId")]
        public Guid DocumentId { get; set; }

        [DataMember(Name = "contentVersion")]
        public int? ContentVersion { get; set; }
    }
}

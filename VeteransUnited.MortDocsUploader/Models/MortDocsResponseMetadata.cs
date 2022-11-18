using VeteransUnited.MortDocsUploader.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace VeteransUnited.MortDocsUploader.Models
{
    public class MortDocsResponseMetadata
    {
        [DataMember(Name = "documentId")]
        public Guid? DocumentId { get; set; }

        [DataMember(Name = "documentState")]
        public DocumentState? DocumentState { get; set; }

        [DataMember(Name = "reviewState")]
        public ReviewState? ReviewState { get; set; }

        [DataMember(Name = "storages")]
        public List<Storage> Storages { get; set; }

        [DataMember(Name = "documentType")]
        public string DocumentType { get; set; }

        [DataMember(Name = "documentTitle")]
        public string DocumentTitle { get; set; }

        [DataMember(Name = "uploadTitle")]
        public string UploadTitle { get; set; }

        [DataMember(Name = "documentDescription")]
        public string DocumentDescription { get; set; }
 
        [DataMember(Name = "loanGuid")]
        public Guid? LoanGuid { get; set; }

        [DataMember(Name = "contentVersion")]
        public int? ContentVersion { get; set; }

        [DataMember(Name = "createdDate")]
        public DateTime? CreatedDate { get; set; }

        [DataMember(Name = "originalDocs")]
        public List<OriginalDoc> OriginalDocs { get; set; }

        [DataMember(Name = "signature")]
        public Signature Signature { get; set; }

        [DataMember(Name = "ContentUri")]
        public string ContentUri { get; set; }
    }

    public class Storage
    {
        [DataMember(Name = "system")]
        public string System { get; set; }

        [DataMember(Name = "state")]
        public StorageState? State { get; set; }
    }

    public class Signature
    {
        [DataMember(Name = "authorizingEmployeeId")]
        public string AuthorizingEmployeeId { get; set; }

        [DataMember(Name = "signed")]
        public bool? Signed { get; private set; }
    }
}
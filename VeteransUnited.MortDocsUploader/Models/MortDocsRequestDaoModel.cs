using System;
using System.Collections.Generic;

namespace VeteransUnited.MortDocsUploader.Models
{
    public class MortDocsRequestDaoModel
    {
        public Guid CorrelationId { get; set; }
        public MortDocsRequestMetadata Metadata { get; set; }
    }

    public class MortDocsRequestMetadata
    {
        public string DocumentType { get; set; }
        public string FileName { get; set; }
        public string DocumentState { get; set; }
        public string ReviewState { get; set; }
        public string DocumentTitle { get; set; }
        public string UploadTitle { get; set; }
        public string DocumentDescription { get; set; }
        public Guid LoanGuid { get; set; }
        public List<OriginalDoc> OriginalDocs { get; set; }
        public KeyValuePair<string,string> SupplementalData { get; set; }
    }
}
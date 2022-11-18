using System;

namespace VeteransUnited.MortDocsUploader.Models
{
    internal struct PendingUpload
    {
        public Guid ResultGuid { get; }
        public Guid LoanGuid { get; }
        public DocumentResource[] Resources { get; }

        public PendingUpload(Guid resultGuid, Guid loanGuid, DocumentResource[] resources)
            => (ResultGuid, LoanGuid, Resources) = (resultGuid, loanGuid, resources);
    }
}

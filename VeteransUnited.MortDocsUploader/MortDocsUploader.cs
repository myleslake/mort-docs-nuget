using System;
using System.Threading.Tasks;

namespace VeteransUnited.MortDocsUploader
{
    public class MortDocsUploader : IMortDocsUploader
    {
        public MortDocsUploader()
        {

        }

        public async Task UploadDocumentAsync(Guid loanGuid, byte[] document)
        {
            // validate request model & document byte array


        }
    }
}

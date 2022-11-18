using System;
using System.Threading.Tasks;
using VeteransUnited.MortDocsUploader.Enums;
using VeteransUnited.MortDocsUploader.Extensions;
using VeteransUnited.MortDocsUploader.Interfaces;
using VeteransUnited.MortDocsUploader.Models;

namespace VeteransUnited.MortDocsUploader
{
    public class MortDocsUploader : IMortDocsUploader
    {
        private readonly IMortDocsClient _mortDocsClient;

        public MortDocsUploader(MortDocsEnvironment env) : this(env.HostName()) { }

        public MortDocsUploader(Uri environmentUri) : this(new MortDocsClient(environmentUri, "apiKey")) { }

        public MortDocsUploader(IMortDocsClient mortDocsClient)
        {
            _mortDocsClient = mortDocsClient;
        }

        public async Task UploadDocumentAsync(MortDocsRequestDaoModel request, byte[] document)
        {
            throw new NotImplementedException();
            // validate request model & document byte array

            // call MortDocsClient to upload document

            // return success to user

            // handle exceptions
        }
    }
}

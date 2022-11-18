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
        public MortDocsUploader(MortDocsEnvironment env) : this(env.HostName()) { }

        public MortDocsUploader(Uri environmentUri)
        {

        }


        public async Task UploadDocumentAsync(MortDocsRequestDaoModel request, byte[] document)
        {
            // validate request model & document byte array

            // call MortDocsClient to upload document

            // return success to user

            // handle exceptions
        }
    }
}

using System.Threading.Tasks;
using VeteransUnited.MortDocsUploader.Models;

namespace VeteransUnited.MortDocsUploader.Interfaces
{
    internal interface IMortDocsClient
    {
        Task<MortDocsResponseModel> UploadDocumentAsync(MortDocsRequestDaoModel request, byte[] document);
        Task<bool> CanConnect();
    }
}

using System;
using System.Net.Http;
using System.Threading.Tasks;
using VeteransUnited.MortDocsUploader.Interfaces;
using VeteransUnited.MortDocsUploader.Models;

namespace VeteransUnited.MortDocsUploader
{
    public sealed class MortDocsClient : IMortDocsClient, IDisposable
    {
        private readonly HttpClient _httpClient;

        public MortDocsClient(Uri baseAddress, string apiKey)
        {
            // TODO: Validate inputs

            _httpClient = new HttpClient
            {
                BaseAddress = baseAddress
            };
            _httpClient.DefaultRequestHeaders.Add("X-Api-Key", apiKey);
        }
        //Task<MortDocsResponseModel> IMortDocsClient.UploadDocumentAsync(MortDocsRequestDaoModel request, byte[] document)
        public async Task<MortDocsResponseModel> UploadDocumentAsync(MortDocsRequestDaoModel request, byte[] document)
        {
            throw new NotImplementedException();

            // TODO: Add try/catch around api call
            // TODO: Add retry around api call?
            // TODO: Dispose of HttpClient when we are done to conserve resources
            // TODO: Does request/response need to follow ADR?

            //var content = new MultipartFormDataContent();

            //// Add request model to request content
            //var requestJson = JsonConvert.SerializeObject(request);
            //var requestString = new StringContent(requestJson, Encoding.UTF8, "application/json");
            //content.Add(requestString, "document");

            //// Add document to be uploaded to request content
            //var bytecontent = new ByteArrayContent(document);
            //content.Add(bytecontent, "file", request.Metadata.FileName);

            //// Call MortDocs 'Documents' endpoint
            //var result = await _httpClient.PostAsync("Documents", content);

            //// Get response
            //var stringAsync = await result.Content.ReadAsStringAsync();
            //var mortDocsResponseModel = JsonConvert.DeserializeObject<MortDocsResponseModel>(stringAsync);

            //// Validate response
            //if (mortDocsResponseModel?.Data == null && mortDocsResponseModel?.Error == null)
            //{
            //    throw new Exception($"Status code: {(int)result.StatusCode}. Response content: {stringAsync}");
            //}

            //return mortDocsResponseModel;
        }

        public async Task<bool> CanConnect()
        {
            throw new NotImplementedException();
            //try
            //{                
            //    // Call MortDocs Health endpoint: https://mortdocs.d.vu.local/MortgageDocumentApi/Health

            //    // Determine if call was successful

            //    // This is how SecretKeeper is handling this method
            //    //var response = await _webRequestManager.GetStringAsync($"{VERSION_ROUTE}").ConfigureAwait(false);
            //    //var versionResult = JsonConvert.DeserializeObject<VersionResult>(response);
            //    //return versionResult.success;
            //}
            //catch (Exception)
            //{
            //    return false;
            //}
        }

        public void Dispose()
        {
            throw new NotImplementedException();
            //_httpClient?.Dispose();
        }
    }
}

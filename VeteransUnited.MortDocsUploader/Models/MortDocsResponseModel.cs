using System.Runtime.Serialization;

namespace VeteransUnited.MortDocsUploader.Models
{
    public class MortDocsResponseModel
    {
        public MortDocsResponseData Data { get; set; }

        [DataMember(Name = "apiVersion")]
        public string ApiVersion { get; set; }

        [DataMember(Name = "context")]
        public string Context { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "method")]
        public string Method { get; set; }

        [DataMember(Name = "params")]
        public JsonResponseParams Params { get; set; }

        [DataMember(Name = "error")]
        public MortDocsErrorParentModel Error { get; set; }
    }

    public class JsonResponseParams
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
    }
}
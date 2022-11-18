using Newtonsoft.Json;

namespace VeteransUnited.MortDocsUploader.Models
{
    internal class DocumentResource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("elli-signature")]
        public string ElliSignature { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
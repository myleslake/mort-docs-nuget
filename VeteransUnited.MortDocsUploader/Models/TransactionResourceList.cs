using Newtonsoft.Json;

namespace VeteransUnited.MortDocsUploader.Models
{
    internal class TransactionResourceList
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("resources")]
        public DocumentResource[] Resources { get; set; }
    }
}

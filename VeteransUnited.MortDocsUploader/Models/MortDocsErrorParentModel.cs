using System.Collections.Generic;

namespace VeteransUnited.MortDocsUploader.Models
{
    public class MortDocsErrorParentModel
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public List<MortDocsErrorModel> Errors { get; set; }
    }
    public class MortDocsErrorModel
    {
        public string Domain { get; set; }
        public string Reason { get; set; }
        public string Message { get; set; }
        public string Location { get; set; }
        public string LocationType { get; set; }
        public string ExtendedHelp { get; set; }
        public string SendReport { get; set; }
    }
}

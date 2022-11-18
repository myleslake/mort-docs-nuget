using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace VeteransUnited.MortDocsUploader.Models
{
    public class MortDocsResponseData
    {
        public List<MortDocsResponseMetadata> items { get; set; }

        [DataMember(Name = "kind")]
        public string Kind { get; set; }

        [DataMember(Name = "fields")]
        public string Fields { get; set; }

        [DataMember(Name = "etag")]
        public string Etag { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "lang")]
        public string Lang { get; set; }

        [DataMember(Name = "updated")]
        public DateTime? Updated { get; set; }

        [DataMember(Name = "deleted")]
        public DateTime? Deleted { get; set; }

        [DataMember(Name = "currentItemCount")]
        public int? CurrentItemCount { get; set; }

        [DataMember(Name = "itemsPerPage")]
        public int? ItemsPerPage { get; set; }

        [DataMember(Name = "startIndex")]
        public int? StartIndex { get; set; }

        [DataMember(Name = "totalItems")]
        public int? TotalItems { get; set; }

        [DataMember(Name = "pageIndex")]
        public int? PageIndex { get; set; }

        [DataMember(Name = "totalPages")]
        public int? TotalPages { get; set; }

        [DataMember(Name = "pageLinkTemplate")]
        public string PageLinkTemplate { get; set; }

        [DataMember(Name = "next")]
        public Object Next { get; set; }

        [DataMember(Name = "nextLink")]
        public string NextLink { get; set; }

        [DataMember(Name = "previous")]
        public Object Previous { get; set; }

        [DataMember(Name = "previousLink")]
        public string PreviousLink { get; set; }

        [DataMember(Name = "self")]
        public Object Self { get; set; }

        [DataMember(Name = "selfLink")]
        public string SelfLink { get; set; }

        [DataMember(Name = "edit")]
        public Object Edit { get; set; }

        [DataMember(Name = "editLink")]
        public string EditLink { get; set; }

    }
}

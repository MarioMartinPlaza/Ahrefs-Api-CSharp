namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsBrokenLinks
    {
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Link> Links { get; set; }
    }

    public partial class Link
    {
        [JsonProperty("url_from", NullValueHandling = NullValueHandling.Ignore)]
        public Uri UrlFrom { get; set; }

        [JsonProperty("ahrefs_rank", NullValueHandling = NullValueHandling.Ignore)]
        public long? AhrefsRank { get; set; }

        [JsonProperty("domain_to_rating", NullValueHandling = NullValueHandling.Ignore)]
        public long? DomainToRating { get; set; }

        [JsonProperty("domain_to_ahrefs_top", NullValueHandling = NullValueHandling.Ignore)]
        public long? DomainToAhrefsTop { get; set; }

        [JsonProperty("ip_from", NullValueHandling = NullValueHandling.Ignore)]
        public string IpFrom { get; set; }

        [JsonProperty("links_internal", NullValueHandling = NullValueHandling.Ignore)]
        public long? LinksInternal { get; set; }

        [JsonProperty("links_external", NullValueHandling = NullValueHandling.Ignore)]
        public long? LinksExternal { get; set; }

        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? PageSize { get; set; }

        [JsonProperty("encoding", NullValueHandling = NullValueHandling.Ignore)]
        public string Encoding { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        [JsonProperty("url_to", NullValueHandling = NullValueHandling.Ignore)]
        public Uri UrlTo { get; set; }

        [JsonProperty("first_seen", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FirstSeen { get; set; }

        [JsonProperty("last_visited", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastVisited { get; set; }

        [JsonProperty("prev_visited", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PrevVisited { get; set; }

        [JsonProperty("original", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Original { get; set; }

        [JsonProperty("redirect", NullValueHandling = NullValueHandling.Ignore)]
        public long? Redirect { get; set; }

        [JsonProperty("alt", NullValueHandling = NullValueHandling.Ignore)]
        public string Alt { get; set; }

        [JsonProperty("anchor", NullValueHandling = NullValueHandling.Ignore)]
        public string Anchor { get; set; }

        [JsonProperty("text_pre", NullValueHandling = NullValueHandling.Ignore)]
        public string TextPre { get; set; }

        [JsonProperty("text_post", NullValueHandling = NullValueHandling.Ignore)]
        public string TextPost { get; set; }

        [JsonProperty("url_from_first_seen", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UrlFromFirstSeen { get; set; }

        [JsonProperty("first_origin", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstOrigin { get; set; }

        [JsonProperty("last_origin", NullValueHandling = NullValueHandling.Ignore)]
        public string LastOrigin { get; set; }

        [JsonProperty("link_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LinkType { get; set; }

        [JsonProperty("nofollow", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nofollow { get; set; }

        [JsonProperty("broken_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? BrokenAt { get; set; }

        [JsonProperty("http_code", NullValueHandling = NullValueHandling.Ignore)]
        public long? HttpCode { get; set; }

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }
    }

}

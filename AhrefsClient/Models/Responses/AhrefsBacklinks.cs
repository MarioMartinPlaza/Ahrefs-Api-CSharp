namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsBacklinks
    {
        [JsonProperty("refpages")]
        public List<Refpage> Refpages { get; set; }
    }

    public partial class Refpage
    {
        /// <summary>
        /// URL of the page where the backlink is found.
        /// </summary>
        [JsonProperty("url_from", NullValueHandling = NullValueHandling.Ignore)]
        public Uri UrlFrom { get; set; }

        /// <summary>
        /// URL of the page the backlink is pointing to.
        /// </summary>
        [JsonProperty("url_to", NullValueHandling = NullValueHandling.Ignore)]
        public Uri UrlTo { get; set; }
        /// <summary>
        /// URL Rating of the referring page.
        /// </summary>
        [JsonProperty("ahrefs_rank", NullValueHandling = NullValueHandling.Ignore)]
        public long? AhrefsRank { get; set; }

        /// <summary>
        /// Domain Rating of the referring domain.
        /// </summary>
        [JsonProperty("domain_rating", NullValueHandling = NullValueHandling.Ignore)]
        public long? DomainRating { get; set; }

        /// <summary>
        /// Ahrefs Rank of the target domain.
        /// </summary>
        [JsonProperty("ahrefs_top", NullValueHandling = NullValueHandling.Ignore)]
        public long? AhrefsTop { get; set; }

        /// <summary>
        /// IP address of the referring page.
        /// </summary>
        [JsonProperty("ip_from", NullValueHandling = NullValueHandling.Ignore)]
        public string IpFrom { get; set; }

        /// <summary>
        /// Number of internal links found in the referring page.
        /// </summary>
        [JsonProperty("links_internal", NullValueHandling = NullValueHandling.Ignore)]
        public long? LinksInternal { get; set; }

        /// <summary>
        /// Number of external links found in the referring page.
        /// </summary>
        [JsonProperty("links_external", NullValueHandling = NullValueHandling.Ignore)]
        public long? LinksExternal { get; set; }

        /// <summary>
        /// Size of the referring page, in bytes.
        /// </summary>
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? PageSize { get; set; }

        /// <summary>
        /// Character encoding of the referring page, for example "utf8" or "iso-8859-1" (Latin-1).
        /// </summary>
        [JsonProperty("encoding", NullValueHandling = NullValueHandling.Ignore)]
        public string Encoding { get; set; }

        /// <summary>
        /// Language of the referring page (ISO 639-1).
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// Title of the referring page.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Least recent date when the Ahrefs crawler was able to visit the backlink.
        /// </summary>
        [JsonProperty("first_seen", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FirstSeen { get; set; }

        /// <summary>
        /// Most recent date when the Ahrefs crawler was able to visit the backlink.
        /// </summary>
        [JsonProperty("last_visited", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastVisited { get; set; }

        /// <summary>
        /// Second to the most recent date when the Ahrefs crawler was able to visit the backlink.
        /// </summary>
        [JsonProperty("prev_visited", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PrevVisited { get; set; }

        /// <summary>
        /// Indicates whether the backlink was present on the referring page when the Ahrefs crawler first visited it.
        /// </summary>
        [JsonProperty("original", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Original { get; set; }

        /// <summary>
        /// Either "href", "redirect", "frame", "form", "canonical", "rss", or "alternate".
        /// </summary>
        [JsonProperty("link_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LinkType { get; set; }

        /// <summary>
        /// For redirected links, the Redirect Code (3XX), zero otherwise.
        /// </summary>
        [JsonProperty("redirect", NullValueHandling = NullValueHandling.Ignore)]
        public long? Redirect { get; set; }

        /// <summary>
        /// Indicates whether the backlink is NoFollow.
        /// </summary>
        [JsonProperty("nofollow", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nofollow { get; set; }

        /// <summary>
        /// Alternative text of the image backlink, if exists.
        /// </summary>
        [JsonProperty("alt", NullValueHandling = NullValueHandling.Ignore)]
        public string Alt { get; set; }

        /// <summary>
        /// Anchor text of the backlink.
        /// </summary>
        [JsonProperty("anchor", NullValueHandling = NullValueHandling.Ignore)]
        public string Anchor { get; set; }

        /// <summary>
        /// Snippet before the anchor text.
        /// </summary>
        [JsonProperty("text_pre", NullValueHandling = NullValueHandling.Ignore)]
        public string TextPre { get; set; }

        /// <summary>
        /// Snippet after the anchor text.
        /// </summary>
        [JsonProperty("text_post", NullValueHandling = NullValueHandling.Ignore)]
        public string TextPost { get; set; }

        /// <summary>
        /// The HTTP code for the Link URL.
        /// </summary>
        [JsonProperty("http_code", NullValueHandling = NullValueHandling.Ignore)]
        public long? HttpCode { get; set; }

        /// <summary>
        /// Least recent date when the Ahrefs crawler was able to visit the referring page with backlink.
        /// </summary>
        [JsonProperty("url_from_first_seen", NullValueHandling = NullValueHandling.Ignore)]
        public string UrlFromFirstSeen { get; set; }

        [JsonProperty("first_origin", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstOrigin { get; set; }

        [JsonProperty("last_origin", NullValueHandling = NullValueHandling.Ignore)]
        public string LastOrigin { get; set; }


    }
}

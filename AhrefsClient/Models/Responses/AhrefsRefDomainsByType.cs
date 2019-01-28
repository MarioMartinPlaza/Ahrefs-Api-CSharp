namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsRefDomainsByType
    {
        [JsonProperty("refdomains", NullValueHandling = NullValueHandling.Ignore)]
        public List<Refdomain> Refdomains { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public RefDomainsByTypeStats Stats { get; set; }

        [JsonProperty("tlds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tld> Tlds { get; set; }
    }

    public partial class RefdomainByType : Refdomain
    {

        [JsonProperty("traffic", NullValueHandling = NullValueHandling.Ignore)]
        public double? Traffic { get; set; }

        [JsonProperty("linked_domains", NullValueHandling = NullValueHandling.Ignore)]
        public long? LinkedDomains { get; set; }

        [JsonProperty("refdomains", NullValueHandling = NullValueHandling.Ignore)]
        public long? Refdomains { get; set; }
    }

    public partial class RefDomainsByTypeStats
    {
        /// <summary>
        /// Total number of referring domains that contain at least one link to the target.
        /// </summary>
        [JsonProperty("refdomains", NullValueHandling = NullValueHandling.Ignore)]
        public long? Refdomains { get; set; }

        /// <summary>
        /// Total number of IP addresses that link to the target.
        /// </summary>
        [JsonProperty("ips", NullValueHandling = NullValueHandling.Ignore)]
        public long? Ips { get; set; }

        /// <summary>
        /// Total number of referring class C networks that link to the target.
        /// </summary>
        [JsonProperty("class_c", NullValueHandling = NullValueHandling.Ignore)]
        public long? ClassC { get; set; }

        /// <summary>
        /// Maximum number of backlinks that link to the target, among all of the targets.
        /// </summary>
        [JsonProperty("max_backlinks", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxBacklinks { get; set; }

        /// <summary>
        /// Max number of dofollow backlinks that link to the target, among all of the targets.
        /// </summary>
        [JsonProperty("max_backlinks_dofollow", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxBacklinksDofollow { get; set; }

        /// <summary>
        /// Maximum number of refpages that link to the target, among all of the targets.
        /// </summary>
        [JsonProperty("max_refpages", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxRefpages { get; set; }

        /// <summary>
        /// Total number of backlinks that link to the target, among all of the targets.
        /// </summary>
        [JsonProperty("total_backlinks", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalBacklinks { get; set; }

        /// <summary>
        /// Total number of dofollow backlinks that link to the target, among all of the targets.
        /// </summary>
        [JsonProperty("total_backlinks_dofollow", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalBacklinksDofollow { get; set; }

        /// <summary>
        /// Total amount of referring domains that contain at least one backlink to the target.
        /// </summary>
        [JsonProperty("all", NullValueHandling = NullValueHandling.Ignore)]
        public long? All { get; set; }

        /// <summary>
        /// Total amount of referring domains that contain at least one text backlink to the target.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public long? Text { get; set; }

        /// <summary>
        /// Total amount of referring domains that contain at least one image backlink to the target.
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public long? Image { get; set; }

        /// <summary>
        /// Total amount of referring domains that contain at least one nofollow backlink to the target.
        /// </summary>
        [JsonProperty("nofollow", NullValueHandling = NullValueHandling.Ignore)]
        public long? Nofollow { get; set; }

        /// <summary>
        /// Total amount of referring domains that contain at least one dofollow backlink to the target.
        /// </summary>
        [JsonProperty("dofollow", NullValueHandling = NullValueHandling.Ignore)]
        public long? Dofollow { get; set; }

        /// <summary>
        /// Total amount of referring domains that contain at least one redirect backlink to the target.
        /// </summary>
        [JsonProperty("redirect", NullValueHandling = NullValueHandling.Ignore)]
        public long? Redirect { get; set; }

        /// <summary>
        /// Total amount of referring domains that contain at least one canonical backlink to the target.
        /// </summary>
        [JsonProperty("canonical", NullValueHandling = NullValueHandling.Ignore)]
        public long? Canonical { get; set; }

        /// <summary>
        /// Total amount of referring domains that contain at least one backlink to the target from a governmental refdomain.
        /// </summary>
        [JsonProperty("gov", NullValueHandling = NullValueHandling.Ignore)]
        public long? Gov { get; set; }

        /// <summary>
        /// Total amount of referring domains that contain at least one backlink to the target from an educational refdomain.
        /// </summary>
        [JsonProperty("edu", NullValueHandling = NullValueHandling.Ignore)]
        public long? Edu { get; set; }

        /// <summary>
        /// Total amount of referring domains that contain at least one backlink to the target from an rss refdomain.
        /// </summary>
        [JsonProperty("rss", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rss { get; set; }

        [JsonProperty("alternate", NullValueHandling = NullValueHandling.Ignore)]
        public long? Alternate { get; set; }
    }
}

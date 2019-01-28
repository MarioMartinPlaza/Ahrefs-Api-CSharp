namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsLinkedDomainsByType
    {
        [JsonProperty("domains", NullValueHandling = NullValueHandling.Ignore)]
        public List<DomainByType> Domains { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, long> Stats { get; set; }

        [JsonProperty("tlds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tld> Tlds { get; set; }
    }

    public partial class DomainByType: Domain
    {
        /// <summary>
        /// Ahrefs rank of the external domain.
        /// </summary>
        [JsonProperty("domain_to_top", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainToTop { get; set; }

        /// <summary>
        /// Number of external links from the target that link to the external domain.
        /// </summary>
        [JsonProperty("all", NullValueHandling = NullValueHandling.Ignore)]
        public long? All { get; set; }

        /// <summary>
        /// Number of text external links from the target.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public long? Text { get; set; }

        /// <summary>
        /// Number of image external links from the target.
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public long? Image { get; set; }

        /// <summary>
        /// Number of NoFollow external links from the target.
        /// </summary>
        [JsonProperty("nofollow", NullValueHandling = NullValueHandling.Ignore)]
        public long? Nofollow { get; set; }

        /// <summary>
        /// Number of DoFollow external links from the target.
        /// </summary>
        [JsonProperty("dofollow", NullValueHandling = NullValueHandling.Ignore)]
        public long? Dofollow { get; set; }

        /// <summary>
        /// Number of redirection external links from the target.
        /// </summary>
        [JsonProperty("redirect", NullValueHandling = NullValueHandling.Ignore)]
        public long? Redirect { get; set; }

        /// <summary>
        /// Number of canonical external links from the target.
        /// </summary>
        [JsonProperty("canonical", NullValueHandling = NullValueHandling.Ignore)]
        public long? Canonical { get; set; }

        /// <summary>
        /// Number of external links from the target to governmental domain.
        /// </summary>
        [JsonProperty("gov", NullValueHandling = NullValueHandling.Ignore)]
        public long? Gov { get; set; }

        /// <summary>
        /// Number of external links from the target to educational domain.
        /// </summary>
        [JsonProperty("edu", NullValueHandling = NullValueHandling.Ignore)]
        public long? Edu { get; set; }

        /// <summary>
        /// Number of RSS external links from the target.
        /// </summary>
        [JsonProperty("rss", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rss { get; set; }

        /// <summary>
        /// Number of alternate external links from the target.
        /// </summary>
        [JsonProperty("alternate", NullValueHandling = NullValueHandling.Ignore)]
        public long? Alternate { get; set; }

        /// <summary>
        /// Least recent date when the Ahrefs crawler was able to see the link on the target.
        /// </summary>
        [JsonProperty("first_seen", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FirstSeen { get; set; }

        /// <summary>
        /// Most recent date when the Ahrefs crawler was able to see the link on the target.
        /// </summary>
        [JsonProperty("last_visited", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastVisited { get; set; }

        [JsonProperty("domain_to_linked_domains", NullValueHandling = NullValueHandling.Ignore)]
        public long? DomainToLinkedDomains { get; set; }

        [JsonProperty("domain_to_traffic", NullValueHandling = NullValueHandling.Ignore)]
        public double? DomainToTraffic { get; set; }

        [JsonProperty("domain_to_refdomains", NullValueHandling = NullValueHandling.Ignore)]
        public long? DomainToRefdomains { get; set; }
    }

    public partial class Tld
    {
        [JsonProperty("tld", NullValueHandling = NullValueHandling.Ignore)]
        public string TldTld { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }
    }

}

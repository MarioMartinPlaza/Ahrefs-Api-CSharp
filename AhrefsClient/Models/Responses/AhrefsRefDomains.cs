namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsRefDomains
    {
        [JsonProperty("refdomains", NullValueHandling = NullValueHandling.Ignore)]
        public List<Refdomain> Refdomains { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public RefDoaminsStats Stats { get; set; }
    }

    public partial class Refdomain
    {
        /// <summary>
        /// The referring domain that contains at least one link to the target.
        /// </summary>
        [JsonProperty("refdomain", NullValueHandling = NullValueHandling.Ignore)]
        public string RefdomainRefdomain { get; set; }

        /// <summary>
        /// Number of backlinks found in the referring domain that link to the target.
        /// </summary>
        [JsonProperty("backlinks", NullValueHandling = NullValueHandling.Ignore)]
        public long? Backlinks { get; set; }

        /// <summary>
        /// Number of referring pages found in the referring domain that link to the target.
        /// </summary>
        [JsonProperty("refpages", NullValueHandling = NullValueHandling.Ignore)]
        public long? Refpages { get; set; }

        /// <summary>
        /// Least recent date when the Ahrefs crawler was able to visit the backlinks in the referring domain.
        /// </summary>
        [JsonProperty("first_seen", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FirstSeen { get; set; }

        /// <summary>
        /// Most recent date when the Ahrefs crawler was able to visit the backlinks in the referring domain.
        /// </summary>
        [JsonProperty("last_visited", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastVisited { get; set; }

        /// <summary>
        /// Domain Rating of the referring domain.
        /// </summary>
        [JsonProperty("domain_rating", NullValueHandling = NullValueHandling.Ignore)]
        public long? DomainRating { get; set; }
    }

    public partial class RefDoaminsStats
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
    }

}

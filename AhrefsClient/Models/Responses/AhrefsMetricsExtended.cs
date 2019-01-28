namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsMetricsExtended
    {
        [JsonProperty("metrics", NullValueHandling = NullValueHandling.Ignore)]
        public MetricsExtended Metrics { get; set; }
    }

    public partial class MetricsExtended : Metrics
    {

        /// <summary>
        /// Number of unique pages with non 5xx HTTP code, visited by the Ahrefs crawler on the target.
        /// </summary>
        [JsonProperty("valid_pages", NullValueHandling = NullValueHandling.Ignore)]
        public long? ValidPages { get; set; }

        /// <summary>
        /// Number of RSS external links from the target.
        /// </summary>
        [JsonProperty("rss", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rss { get; set; }

        /// <summary>
        /// Number of alternate backlinks that link to the target.
        /// </summary>
        [JsonProperty("alternate", NullValueHandling = NullValueHandling.Ignore)]
        public long? Alternate { get; set; }

        /// <summary>
        /// Number of domains containing at least one backlink that links to the target.
        /// </summary>
        [JsonProperty("refdomains", NullValueHandling = NullValueHandling.Ignore)]
        public long? Refdomains { get; set; }

        /// <summary>
        /// Number of referring class C networks that link to the target.
        /// </summary>
        [JsonProperty("refclass_c", NullValueHandling = NullValueHandling.Ignore)]
        public long? RefclassC { get; set; }

        /// <summary>
        /// Number of distinct IP addresses under a single network that link to the target.
        /// </summary>
        [JsonProperty("refips", NullValueHandling = NullValueHandling.Ignore)]
        public long? Refips { get; set; }

        /// <summary>
        /// Number of internal or external domains that are linked from the target.
        /// </summary>
        [JsonProperty("linked_root_domains", NullValueHandling = NullValueHandling.Ignore)]
        public long? LinkedRootDomains { get; set; }
    }
}

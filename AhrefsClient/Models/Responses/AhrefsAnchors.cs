namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsAnchors
    {
        [JsonProperty("anchors", NullValueHandling = NullValueHandling.Ignore)]
        public List<Anchor> Anchors { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public AnchorsStats Stats { get; set; }
    }

    public partial class Anchor
    {
        /// <summary>
        /// Anchor text used in at least one backlink from the referring domain
        /// </summary>
        [JsonProperty("anchor", NullValueHandling = NullValueHandling.Ignore)]
        public string AnchorAnchor { get; set; }

        /// <summary>
        /// Number of external backlinks found that are using the anchor text.
        /// </summary>
        [JsonProperty("backlinks", NullValueHandling = NullValueHandling.Ignore)]
        public long? Backlinks { get; set; }


        /// <summary>
        /// Number of pages found containing backlinks that are using the anchor text.
        /// </summary>
        [JsonProperty("refpages", NullValueHandling = NullValueHandling.Ignore)]
        public long? Refpages { get; set; }

        /// <summary>
        /// Referring domain that contains at least one backlink using the anchor text.
        /// </summary>
        [JsonProperty("refdomain", NullValueHandling = NullValueHandling.Ignore)]
        public long? Refdomain { get; set; }
        /// <summary>
        /// Number of referring domains that are using the anchor text when linking to the target.
        /// </summary>
        [JsonProperty("refdomains", NullValueHandling = NullValueHandling.Ignore)]
        public long? Refdomains { get; set; }

        /// <summary>
        /// Least recent date when the Ahrefs crawler was able to visit the backlink that is using the anchor text.
        /// </summary>
        [JsonProperty("first_seen", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FirstSeen { get; set; }

        /// <summary>
        /// Most recent date when the Ahrefs crawler was able to visit the backlink that is using the anchor text.
        /// </summary>
        [JsonProperty("last_visited", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastVisited { get; set; }
    }

    public partial class AnchorsStats
    {
        /// <summary>
        /// Total number of backlinks that are using the anchor.
        /// </summary>
        [JsonProperty("backlinks", NullValueHandling = NullValueHandling.Ignore)]
        public long? Backlinks { get; set; }

        /// <summary>
        /// Total number of referring pages that are using the anchor.
        /// </summary>
        [JsonProperty("refpages", NullValueHandling = NullValueHandling.Ignore)]
        public long? Refpages { get; set; }
    }   
}

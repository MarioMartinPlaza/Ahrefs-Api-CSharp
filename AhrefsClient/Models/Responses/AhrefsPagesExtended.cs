namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsPagesExtended
    {
        [JsonProperty("pages", NullValueHandling = NullValueHandling.Ignore)]
        public List<Page> Pages { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public PagesStats Stats { get; set; }
    }

    public partial class PageExtended : Page
    {
        /// <summary>
        /// Number of external backlinks found on the referring pages that link to the crawled page.
        /// </summary>
        [JsonProperty("backlinks", NullValueHandling = NullValueHandling.Ignore)]
        public long? Backlinks { get; set; }

        /// <summary>
        /// Number of DoFollow backlinks that link to the crawled page.
        /// </summary>
        [JsonProperty("dofollow", NullValueHandling = NullValueHandling.Ignore)]
        public long? Dofollow { get; set; }

        /// <summary>
        /// Number of NoFollow backlinks that link to the crawled page.
        /// </summary>
        [JsonProperty("nofollow", NullValueHandling = NullValueHandling.Ignore)]
        public long? Nofollow { get; set; }

        /// <summary>
        /// Number of pages found that redirect to the crawled page.
        /// </summary>
        [JsonProperty("redirects", NullValueHandling = NullValueHandling.Ignore)]
        public long? Redirects { get; set; }

        /// <summary>
        /// Number of domains containing at least one backlink that links to the crawled page.
        /// </summary>
        [JsonProperty("refdomains", NullValueHandling = NullValueHandling.Ignore)]
        public long? Refdomains { get; set; }

        /// <summary>
        /// Number of referring class C networks that link to the crawled page.
        /// </summary>
        [JsonProperty("refclass_c", NullValueHandling = NullValueHandling.Ignore)]
        public long? RefclassC { get; set; }

        /// <summary>
        /// Number of distinct IP addresses under a single network that link to the crawled page.
        /// </summary>
        [JsonProperty("refips", NullValueHandling = NullValueHandling.Ignore)]
        public long? Refips { get; set; }
    }

    public partial class PagesStats
    {
        [JsonProperty("pages", NullValueHandling = NullValueHandling.Ignore)]
        public long? Pages { get; set; }
    }
}

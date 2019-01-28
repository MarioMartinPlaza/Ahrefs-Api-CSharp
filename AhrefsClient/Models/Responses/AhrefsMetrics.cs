namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsMetrics
    {
        [JsonProperty("metrics", NullValueHandling = NullValueHandling.Ignore)]
        public Metrics Metrics { get; set; }
    }

    public partial class Metrics
    {
        /// <summary>
        /// Number of external backlinks found on the referring pages that link to the target.
        /// </summary>
        [JsonProperty("backlinks", NullValueHandling = NullValueHandling.Ignore)]
        public long? Backlinks { get; set; }

        /// <summary>
        /// Number of external web pages containing at least one backlink that links to the target.
        /// </summary>
        [JsonProperty("refpages", NullValueHandling = NullValueHandling.Ignore)]
        public long? Refpages { get; set; }

        /// <summary>
        /// Number of unique pages visited by the Ahrefs crawler on the target.
        /// </summary>
        [JsonProperty("pages", NullValueHandling = NullValueHandling.Ignore)]
        public long? Pages { get; set; }

        /// <summary>
        /// Number of backlinks that use anchor texts.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public long? Text { get; set; }

        /// <summary>
        /// Number of backlinks that use image as an anchor.
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public long? Image { get; set; }

        /// <summary>
        /// Number of NoFollow backlinks that link to the target.
        /// </summary>
        [JsonProperty("nofollow", NullValueHandling = NullValueHandling.Ignore)]
        public long? Nofollow { get; set; }

        /// <summary>
        /// Number of DoFollow backlinks that link to the target.
        /// </summary>
        [JsonProperty("dofollow", NullValueHandling = NullValueHandling.Ignore)]
        public long? Dofollow { get; set; }

        /// <summary>
        /// Number of redirects found that forward to the target.
        /// </summary>
        [JsonProperty("redirect", NullValueHandling = NullValueHandling.Ignore)]
        public long? Redirect { get; set; }

        /// <summary>
        /// Number of canonical backlinks that link to the target.
        /// </summary>
        [JsonProperty("canonical", NullValueHandling = NullValueHandling.Ignore)]
        public long? Canonical { get; set; }

        /// <summary>
        /// Number of backlinks of all types (including images and NoFollow) found on web pages on governmental domains that link to the target.
        /// </summary>
        [JsonProperty("gov", NullValueHandling = NullValueHandling.Ignore)]
        public long? Gov { get; set; }

        /// <summary>
        /// Number of backlinks of all types (including images and NoFollow) found on web pages on educational domains that link to the target.
        /// </summary>
        [JsonProperty("edu", NullValueHandling = NullValueHandling.Ignore)]
        public long? Edu { get; set; }

        /// <summary>
        /// Number of HTML pages the target link has.
        /// </summary>
        [JsonProperty("html_pages", NullValueHandling = NullValueHandling.Ignore)]
        public long? HtmlPages { get; set; }

        /// <summary>
        /// Number of internal links found in the target.
        /// </summary>
        [JsonProperty("links_internal", NullValueHandling = NullValueHandling.Ignore)]
        public long? LinksInternal { get; set; }

        /// <summary>
        /// Number of external links found in the target.
        /// </summary>
        [JsonProperty("links_external", NullValueHandling = NullValueHandling.Ignore)]
        public long? LinksExternal { get; set; }
    }
}

namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsPages
    {
        [JsonProperty("pages", NullValueHandling = NullValueHandling.Ignore)]
        public List<Page> Pages { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public PagesStats Stats { get; set; }
    }

    public partial class Page
    {
        /// <summary>
        /// URL of the crawled page.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        /// <summary>
        /// URL Rating of the page.
        /// </summary>
        [JsonProperty("ahrefs_rank", NullValueHandling = NullValueHandling.Ignore)]
        public long? AhrefsRank { get; set; }

        /// <summary>
        /// La fecha en que el bot de Ahrefs encontró primero un enlace con el sitio web o la URL destino en una página de referencia determinada.
        /// </summary>
        [JsonProperty("first_seen", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FirstSeen { get; set; }

        /// <summary>
        /// Most recent date when the Ahrefs crawler was able to crawl the page.
        /// </summary>
        [JsonProperty("last_visited", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastVisited { get; set; }

        /// <summary>
        /// HTTP code that was last returned for the page.
        /// </summary>
        [JsonProperty("http_code", NullValueHandling = NullValueHandling.Ignore)]
        public long? HttpCode { get; set; }

        /// <summary>
        /// Size of the crawled page, in bytes.
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        /// <summary>
        /// Number of internal links found in the crawled page.
        /// </summary>
        [JsonProperty("links_internal", NullValueHandling = NullValueHandling.Ignore)]
        public long? LinksInternal { get; set; }

        /// <summary>
        /// Number of external links found in the crawled page.
        /// </summary>
        [JsonProperty("links_external", NullValueHandling = NullValueHandling.Ignore)]
        public long? LinksExternal { get; set; }

        /// <summary>
        /// Character encoding of the page, for example "utf8" or "iso-8859-1" (Latin-1).
        /// </summary>
        [JsonProperty("encoding", NullValueHandling = NullValueHandling.Ignore)]
        public string Encoding { get; set; }

        /// <summary>
        /// Title of the crawled page.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// URL where the page redirects to.
        /// </summary>
        [JsonProperty("redirect_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Type of encoding used to compress the page data, for example "gzip" or "deflate".
        /// </summary>
        [JsonProperty("content_encoding", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentEncoding { get; set; }
    }
}

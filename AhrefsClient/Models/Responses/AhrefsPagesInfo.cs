namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsPagesInfo
    {
        [JsonProperty("pages", NullValueHandling = NullValueHandling.Ignore)]
        public List<Page> Pages { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public PagesStats Stats { get; set; }
    }

    public partial class PageInfo : Page
    {
        /// <summary>
        /// IP address of the server that returned the page.
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public double? Time { get; set; }

        [JsonProperty("words", NullValueHandling = NullValueHandling.Ignore)]
        public long? Words { get; set; }
       

        [JsonProperty("links_images", NullValueHandling = NullValueHandling.Ignore)]
        public long? LinksImages { get; set; }

        /// <summary>
        /// Canonical URL of the page.
        /// </summary>
        [JsonProperty("canonical_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CanonicalUrl { get; set; }


        /// <summary>
        /// Description of the crawled page.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Description { get; set; }

        /// <summary>
        /// Contents of meta tags for social sharing sites.
        /// </summary>
        [JsonProperty("meta_social", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MetaSocial { get; set; }

        [JsonProperty("h1", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> H1 { get; set; }

        [JsonProperty("h2", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> H2 { get; set; }

        [JsonProperty("images_alt", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ImagesAlt { get; set; }

        [JsonProperty("powered_by", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> PoweredBy { get; set; }

        [JsonProperty("render_result", NullValueHandling = NullValueHandling.Ignore)]
        public string RenderResult { get; set; }
    }

}
